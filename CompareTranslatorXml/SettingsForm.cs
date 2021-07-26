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
        LanguageResolver translator = new LanguageResolver();
        private Config config = new Config();

        public SettingsForm()
        {
            InitializeComponent();
            InitializeLocalComponent();
            InitializeSettings();

            LanguageResolver.PropertyChanged += new PropertyChangedEventHandler(LanguageChanged);
        }

        private void LanguageChanged()
        {

        }

        /// <summary>
        /// Tải các cài đặt đã được cấu hình
        /// </summary>
        private void InitializeSettings()
        {
            SelectLangCb.SelectedValue = config.GetValue(Config.LANGUAGE_KEY);
            AutoSaveChk.Checked = bool.Parse(config.GetValue(Config.ENABLE_AUTO_SAVE_KEY));
            AutoSaveTypeCb.SelectedValue = int.Parse(config.GetValue(Config.AUTO_SAVE_TYPE_KEY));
            IdleTimeTxt.Text = config.GetValue(Config.IDLE_TIME);
        }

        private void InitializeLocalComponent()
        {
            #region Auto Save Setting
            AutoSaveChk.Text = translator.Translate("0034", "Auto Save");
            #endregion

            #region Saving Settings
            /// INIT AutoSaveType Items
            List<AutoSaveType> items = new List<AutoSaveType>()
            {
                { new AutoSaveType() { Value = AutoSaveType.IDLE, Label = translator.Translate("0027", "Không làm gì")} },
                { new AutoSaveType() { Value = AutoSaveType.END_EDIT, Label = translator.Translate("0028", "Sửa xong một dòng")} }
            };
            AutoSaveTypeCb.DataSource = items;
            AutoSaveTypeCb.DisplayMember = "Label";
            AutoSaveTypeCb.ValueMember = "Value";
            AutoSaveTypeCb.SelectedValue = AutoSaveType.END_EDIT;
            // Init Language
            SavingGroupBox.Text = translator.Translate("0029", "Lưu trữ");
            AutoSaveTypeLabel.Text = translator.Translate("0030", "Tự động lưu khi");
            TimeSecondLbl.Text = translator.Translate("0031", "Giây");
            IdleInLabel.Text = translator.Translate("0032", "Trong");
            #endregion

            #region Language settings
            List<Language> langs = new List<Language>()
            {
                { new Language() { Label = translator.Translate("vn", "Tiếng Việt", "languages"), Code = Language.VN} },
                { new Language() { Label = translator.Translate("en", "Tiếng anh", "languages"), Code = Language.EN } }
            };
            SelectLangCb.DataSource = langs;
            SelectLangCb.DisplayMember = "Label";
            SelectLangCb.ValueMember = "Code";
            SelectLangLbl.Text = translator.Translate("0033", "Ngôn ngữ");
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
            Close();
        }

        private void ChangeLanguage(object sender, EventArgs e)
        {
            
        }


    }
}
