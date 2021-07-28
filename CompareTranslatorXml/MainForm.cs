using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CompareTranslatorXml
{
    public partial class MainForm : Form
    {
        // BindingList<StringObject> strings = new BindingList<StringObject>();
        SortedBindingList<StringObject> strings = new SortedBindingList<StringObject>();

        Processor processor;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        readonly LanguageResolver translator = new LanguageResolver();
        bool isCurrentFileTxtSet = false;


        public MainForm()
        {
            LanguageResolver.ChangeLanguage += OnLanguageChanged;
            InitializeComponent();
            InitializeLocalComponent();
        }

        private void OnLanguageChanged(object sender, EventArgs e)
        {
            InitializeLocalComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ExitPerform())
            {
                Application.ExitThread();
            } else
            {
                e.Cancel = true;
            }
        }

        private bool ExitPerform()
        {
            try
            {
                StringObject modifiedString = strings.FirstOrDefault(textObject => textObject.HasChanged == true);
                if (modifiedString != null && modifiedString.Id != null)
                {

                    MessageBoxManager.Yes = translator.Translate("0023", "Lưu");
                    MessageBoxManager.No = translator.Translate("0024", "Không lưu");
                    MessageBoxManager.Cancel = translator.Translate("0025", "Huỷ bỏ");
                    MessageBoxManager.Register();

                    DialogResult dialogResult = MessageBox.Show(translator.Translate("0007", "Có sự thay đổi dữ liệu. Bạn vẫn muốn thoát tool?"), translator.Translate("0008", "Nhắc nhở"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    MessageBoxManager.Unregister();
                    if (dialogResult == DialogResult.Yes)
                    {
                        saveData();
                        return true;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception) {}
            return true;
        }

        private void InitializeLocalComponent()
        {
            #region MenuStrip
            fileItem.Text = translator.Translate("0001", "Tệp");
            exitItem.Text = translator.Translate("0002", "Thư Mục");
            editItem.Text = translator.Translate("0003", "Chỉnh sửa");
            optionsItem.Text = translator.Translate("0004", "Cài đặt");
            helpItem.Text = translator.Translate("0005", "Trợ giúp");
            aboutItem.Text = translator.Translate("0006", "Về tôi");
            clearData.Text = translator.Translate("0018", "Làm sạch");
            #endregion

            #region Status Strip
            currentFileLbl.Text = translator.Translate("0010", "Tệp đang thực hiện:");
            currentFileTxt.Text = translator.Translate("0011", "Không");
            NumberCountLbl.Text = translator.Translate("0019", "Số dòng:");
            #endregion

            #region GridView
            listTextGroup.Text = translator.Translate("0012", "Danh sách các text");
            listTextGrid.Columns["Index"].HeaderText = translator.Translate("0013", "Thứ tự");
            listTextGrid.Columns["Id"].HeaderText = translator.Translate("0014", "Mã text");
            listTextGrid.Columns["En"].HeaderText = translator.Translate("0015", "Tiếng Anh");
            listTextGrid.Columns["Cn"].HeaderText = translator.Translate("0016", "Tiếng Trung");
            listTextGrid.Columns["Vn"].HeaderText = translator.Translate("0017", "Tiếng Việt");
            #endregion

            #region INPUT Txt
            EnLoadTxt.Placeholder = translator.Translate("0020", "Chọn file hoặc kéo thả file vào đây");
            VnLoadTxt.Placeholder = translator.Translate("0020", "Chọn file hoặc kéo thả file vào đây");
            CnLoadTxt.Placeholder = translator.Translate("0020", "Chọn file hoặc kéo thả file vào đây");
            #endregion
        }

        private void EnLoadBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                EnLoadTxt.Text = openFileDialog.FileName;
                SetCurrentProcessFileText(Path.GetFileName(EnLoadTxt.Text));
                processor = new Processor(openFileDialog.FileName);
                processor.GetListStringData("En", ref strings);
                listTextGrid.DataSource = strings;
            }

            RefreshGridView();
        }

        private void RefreshGridView()
        {
            numberCountTxt.Text = listTextGrid.Rows.Count.ToString();
            foreach (DataGridViewRow row in listTextGrid.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
                StringObject stringText = strings.FirstOrDefault(text => text.Id == row.Cells["id"].Value.ToString() && text.HasChanged == true);
                if (stringText != null && stringText.Id != null)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 195, 143);
                    continue;
                }
                if (row.Index % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 194, 233, 251);
                }

                if (row.Cells["En"] == null || row.Cells["En"].Value == null) { continue; }
                if (row.Cells["Vn"] == null || row.Cells["Vn"].Value == null) { continue; }
                if (row.Cells["En"].Value.ToString().Equals(row.Cells["Vn"].Value.ToString()))
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 249, 220, 139);
                }
            }
            listTextGrid.Refresh();
        }

        private void CnLoadBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CnLoadTxt.Text = openFileDialog.FileName;
                SetCurrentProcessFileText(Path.GetFileName(CnLoadTxt.Text));
                processor = new Processor(openFileDialog.FileName);
                processor.GetListStringData("Cn", ref strings);
                listTextGrid.DataSource = strings;
            }

            RefreshGridView();
        }

        private void SetCurrentProcessFileText(string fileName)
        {
            if (!isCurrentFileTxtSet)
            {
                isCurrentFileTxtSet = true;
                currentFileTxt.Text = fileName;
                return;
            }
        }

        private void VnLoadBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                VnLoadTxt.Text = openFileDialog.FileName;
                SetCurrentProcessFileText(Path.GetFileName(VnLoadTxt.Text));
                processor = new Processor(openFileDialog.FileName);
                processor.GetListStringData("Vn", ref strings);
                listTextGrid.DataSource = strings;
            }

            RefreshGridView();
        }

        private void _LoadXmlFileToList(string path, string langKey, TextBox tb)
        {
            tb.Text = path;
            SetCurrentProcessFileText(Path.GetFileName(tb.Text));
            processor = new Processor(path);
            processor.GetListStringData(langKey, ref strings);
            listTextGrid.DataSource = strings;
            RefreshGridView();
        }

        private void clearData_Click(object sender, EventArgs e)
        {
            ClearCurrentData();
        }

        private void ClearCurrentData()
        {
            EnLoadTxt.Text = null;
            CnLoadTxt.Text = null;
            VnLoadTxt.Text = null;
            strings.Clear();
            currentFileTxt.Text = translator.Translate("0011", "Không");
            isCurrentFileTxtSet = false;
            numberCountTxt.Text = "0";
        }

        private void VnLoadTxt_DragDrop(object sender, DragEventArgs e)
        {
            _DragDrop(e, VnLoadTxt, "Vn");
        }

        private void _DragDrop(DragEventArgs e, TextBox tb, string langKey)
        {
            DataObject data = (DataObject)e.Data;
            if (data.ContainsFileDropList())
            {
                string[] rawFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (rawFiles != null)
                {
                    List<string> lines = new List<string>();
                    foreach (string path in rawFiles)
                    {
                        tb.Text = path;
                        _LoadXmlFileToList(path, langKey, tb);
                        return;
                    }
                }
            }
        }

        private void _DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void EnLoadTxt_DragDrop(object sender, DragEventArgs e)
        {
            _DragDrop(e, EnLoadTxt, "En");
        }

        private void CnLoadTxt_DragDrop(object sender, DragEventArgs e)
        {
            _DragDrop(e, CnLoadTxt, "Cn");
        }

        private void listTextGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = listTextGrid.Rows[e.RowIndex].Cells["id"].Value.ToString();
                string prop = listTextGrid.Columns[e.ColumnIndex].DataPropertyName.ToString();
                string newValue = listTextGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                StringObject foundStringObject = strings.FirstOrDefault(textObject => textObject.Id == id);
                if (foundStringObject == null || foundStringObject.Id == null)
                {
                    MessageBox.Show("Not found!");
                    return;
                }
                foundStringObject.HasChanged = !newValue.Equals(foundStringObject.GetType().GetProperty("Origin" + prop).GetValue(foundStringObject).ToString());

                if (foundStringObject.HasChanged)
                {
                    RefreshGridView();
                    //listTextGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(183, 85, 1, 100);
                    //listTextGrid.Refresh();
                }
                // Add to string objects
                // processor.AddOrUpdate(prop, ref strings, foundStringObject);
            } catch (Exception exception) {
                MessageBox.Show(translator.Translate("0009", "Lỗi") + ": " + exception.Message);
            }
        }

        private void saveVnBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (VnLoadTxt.Text == null || VnLoadTxt.Text.Equals(""))
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        saveFileDialog.DefaultExt = 
                        VnLoadTxt.Text = saveFileDialog.FileName;
                    }
                }
                saveData();
                RefreshGridView();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, translator.Translate("0009", "Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressStatus.ForeColor = Color.Red;
                progressStatus.Text = translator.Translate("0022", "That bai");
            }
        }

        private void saveData()
        {
            progressBar.Maximum = strings.Count;
            foreach (StringObject str in strings)
            {
                processor = new Processor(VnLoadTxt.Text);
                processor.AddOrUpdate(str);
                str.OriginVn = str.Vn;
                str.HasChanged = false;
                progressBar.PerformStep();
            }

            progressStatus.ForeColor = Color.Green;
            progressStatus.Text = translator.Translate("0021", "Thành công");
        }

        private void exitItem_Click(object sender, EventArgs e)
        {
            if (ExitPerform())
            {
                Application.ExitThread();
            }
        }

        private void reformatGridBtn_Click(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private void aboutItem_Click(object sender, EventArgs e)
        {
            AboutAuthorForm abountAuthForm = new AboutAuthorForm();
            abountAuthForm.StartPosition = FormStartPosition.Manual;
            abountAuthForm.Location = new Point((Location.X + Width / 2) - (abountAuthForm.Width / 2), Location.Y + 50);
            abountAuthForm.Show();
        }
        
        /// <summary>
        /// Mở form cài đặt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenSettings(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            // Đặt vị trí xuất hiện form: ở giữa form chính và tụt xuống 50 point
            settingsForm.Location = new Point((Location.X + Width / 2) - (settingsForm.Width / 2), Location.Y + 50);
            settingsForm.Show();
        }
    }
}
