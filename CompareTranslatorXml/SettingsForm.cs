using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompareTranslatorXml.Model;
using System.Windows.Forms;

namespace CompareTranslatorXml
{
    public partial class SettingsForm : Form
    {
        readonly LanguageResolver translator = new LanguageResolver();
        readonly private Config config = new Config();

        public SettingsForm()
        {
            LanguageResolver.ChangeLanguage += OnLanguageChanged;
            InitializeComponent();
            InitializeLocalComponent();
            InitializeSettings();
        }

        /// <summary>
        /// Khi ngôn ngữ được thay đổi thì sẽ kích hoạt refresh lại context khi ứng dụng đang chạy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLanguageChanged(object sender, EventArgs e)
        {
            InitializeLocalComponent();

            // Set giá trị ngôn ngữ đang chọn cho combobox
            SetSelectedValueLanguageCb(true);
        }

        /// <summary>
        /// Tải các cài đặt đã được cấu hình, khi form được khởi tạo
        /// </summary>
        private void InitializeSettings()
        {
            SetSelectedValueLanguageCb();
            AutoSaveChk.Checked = bool.Parse(config.GetValue(Config.ENABLE_AUTO_SAVE_KEY));
            // AutoSaveTypeCb.SelectedValueChanged += AutoSaveSelectIdleTimeType;
            AutoSaveTypeCb.SelectedValue = int.Parse(config.GetValue(Config.AUTO_SAVE_TYPE_KEY));
            IdleTimeTxt.Text = config.GetValue(Config.IDLE_TIME);
        }

        /// <summary>
        /// Thiết lập ngôn ngữ ui context
        /// </summary>
        private void InitializeLocalComponent()
        {
            Text = translator.Translate("0035", "Cài Đặt");

            #region Auto Save Setting
            AutoSaveChk.Text = translator.Translate("0034", "Auto Save");
            #endregion

            #region Saving Settings
            /// INIT AutoSaveType Items
            AutoSaveType[] autoSaveTypeItems = new AutoSaveType[]
            {
                new AutoSaveType() { Value = AutoSaveType.IDLE, Label = translator.Translate("0027", "Không làm gì")},
                new AutoSaveType() { Value = AutoSaveType.END_EDIT, Label = translator.Translate("0028", "Sửa xong một dòng")}
            };
            // Loại bỏ trigger tới event
            AutoSaveTypeCb.SelectedValueChanged -= AutoSaveSelectIdleTimeType;
            AutoSaveTypeCb.DataSource = autoSaveTypeItems;
            AutoSaveTypeCb.DisplayMember = "Label";
            AutoSaveTypeCb.ValueMember = "Value";
            // Kích hoạt lại các trigger event
            AutoSaveTypeCb.SelectedValueChanged += AutoSaveSelectIdleTimeType;

            // Init Language
            SavingGroupBox.Text = translator.Translate("0029", "Lưu trữ");
            AutoSaveTypeLabel.Text = translator.Translate("0030", "Tự động lưu khi");
            TimeSecondLbl.Text = translator.Translate("0031", "Giây");
            IdleInLabel.Text = translator.Translate("0032", "Trong");
            #endregion

            #region Language settings
            Language[] langs = new Language[]
            {
                new Language() { Label = translator.Translate("vn", "Tiếng Việt", "languages"), Code = Language.VN},
                new Language() { Label = translator.Translate("en", "Tiếng anh", "languages"), Code = Language.EN }
            };
            SelectLangCb.SelectedValueChanged -= ChangeLanguage;
            SelectLangCb.DataSource = langs;
            SelectLangCb.DisplayMember = "Label";
            SelectLangCb.ValueMember = "Code";
            SelectLangLbl.Text = translator.Translate("0033", "Ngôn ngữ");
            SelectLangCb.SelectedValueChanged += ChangeLanguage;
            #endregion

            #region Button Action
            CancelBtn.Text = translator.Translate("0025", "Cancel");
            #endregion
        }

        /// <summary>
        /// Kiểm tra dữ liệu nhập vào có phải là số hay không, nếu ko là số thì hiển thị thông báo lỗi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IdleTimeTxt_Validating(object sender, CancelEventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(IdleTimeTxt.Text, out n);
            ErrorProvider errorProvider = new ErrorProvider();
            if (!isNumeric)
            {
                e.Cancel = true;
                IdleTimeTxt.Focus();
                errorProvider.SetError(IdleTimeTxt, translator.Translate("0001", "Vui lòng nhập số", "noti_msg"));
            }
        }

        /// <summary>
        /// Sự kiện xử lý việc lưu cấu hình cài đặt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveSettings(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                config.Write(Config.LANGUAGE_KEY, SelectLangCb.SelectedValue.ToString());
                config.Write(Config.ENABLE_AUTO_SAVE_KEY, AutoSaveChk.Checked.ToString());
                config.Write(Config.AUTO_SAVE_TYPE_KEY, AutoSaveTypeCb.SelectedValue.ToString());
                config.Write(Config.IDLE_TIME, IdleTimeTxt.Text.ToString());

                Close();
            }
        }

        /// <summary>
        /// Sự kiện xử lý khi bật tắt tự động lưu dữ liệu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnOffAutoSave(object sender, EventArgs e)
        {
            if (AutoSaveChk.Checked)
            {
                AutoSaveTypeSettingPanel.Visible = true;
            } else
            {
                AutoSaveTypeSettingPanel.Visible = false;
            }
        }

        /// <summary>
        /// Sự kiện xử lý việc khi chọn một kiểu tự động lưu trữ.
        /// Khi kiểu lưu trữ là CompareTranslatorXml.Model.AutoSaveType.IDLE
        /// thì sẽ hiển thị phần cài đặt thời gian cho nó
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutoSaveSelectIdleTimeType(object sender, EventArgs e)
        {
            int.TryParse(AutoSaveTypeCb.SelectedValue.ToString(), out int selectedValue);
            if (selectedValue == AutoSaveType.IDLE)
            {
                IdleTimePanel.Visible = true;
            } else
            {
                IdleTimePanel.Visible = false;
            }
        }

        /// <summary>
        /// Đóng form cài đặt và không thực hiện bất cứ hànhd động gì!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            // Force reset to config
            translator.InitializeAppLanguage(true);
            Close();
        }

        private void CloseForm(object sender, FormClosingEventArgs e)
        {
            // Force reset to config
            translator.InitializeAppLanguage(true);
        }

        private void ChangeLanguage(object sender, EventArgs e)
        {
            LanguageResolver.CurrentLanguage = SelectLangCb.SelectedValue.ToString();
        }

        /// <summary>
        /// Set giá trị đang được chọn cho combobox ngôn ngữ
        /// </summary>
        /// <param name="useCurrent">Đặt giá trị theo ngôn ngữ của app hiện tại hay là lấy trong file cấu hình | Mặc định là <see cref="System.Boolean.FalseString"/></param>
        /// <param name="notifyToSubcriber">Xác định xem việc đặt giá trị này có thông báo cho các subcriber khác biết không | Mặc định là <see cref="System.Boolean.FalseString"/></param>
        private void SetSelectedValueLanguageCb(bool useCurrent = false, bool notifyToSubcriber = false)
        {
            string languageCode = LanguageResolver.CurrentLanguage;
            if (!useCurrent)
            {
                languageCode = config.GetValue(Config.LANGUAGE_KEY);
            }
            if (!notifyToSubcriber)
            {
                SelectLangCb.SelectedValueChanged -= ChangeLanguage;
                SelectLangCb.SelectedValue = languageCode;
                SelectLangCb.SelectedValueChanged += ChangeLanguage;
            }
            else
            {
                SelectLangCb.SelectedValue = languageCode;
            }
        }
    }
}
