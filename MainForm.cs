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
        Config config;
        OpenFileDialog openFileDialog;
        LanguageResolver LanguageResolver;
        string currentLang = Config.DEFAULT_LANG;
        public MainForm()
        {
            InitializeComponent();
        }

        /**
         * Load app settings
         */
        private void LoadSettings()
        {
            try
            {
                config = new Config();
                currentLang = config.Read("Settings", "Language");
                this.ProcessLanguageText();
            } catch (Exception e)
            {
                MessageBox.Show(e.Message, LanguageResolver.Read("strings", "0009", "Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(LanguageResolver.Read("strings", "0007", "Bạn có muốn thoát tool?"), LanguageResolver.Read("strings", "0008", "Nhắc nhở"), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            } else
            {
                e.Cancel = true;
            }
        }

        private void ProcessLanguageText()
        {
            // Ghi config mặc định, đặt lang mặc định 
            if (currentLang.Equals(""))
            {
                config.Write(Config.SETTINGS_SECTION, Config.LANGUAGE_SETTING, Config.DEFAULT_LANG);
                currentLang = Config.DEFAULT_LANG;
            }
            LanguageResolver = new LanguageResolver(currentLang);
            #region MenuStrip
            fileItem.Text = LanguageResolver.Read("strings", "0001", "Tệp");
            exitItem.Text = LanguageResolver.Read("strings", "0002", "Thư Mục");
            editItem.Text = LanguageResolver.Read("strings", "0003", "Chỉnh sửa");
            optionsItem.Text = LanguageResolver.Read("strings", "0004", "Cài đặt");
            helpItem.Text = LanguageResolver.Read("strings", "0005", "Trợ giúp");
            aboutItem.Text = LanguageResolver.Read("strings", "0006", "Về tôi");
            #endregion

            #region Status Strip
            currentFileLbl.Text = Translate("0010", "Tệp đang thực hiện:");
            currentFileTxt.Text = Translate("0011", "Không");
            #endregion
        }

        private string Translate(string key, string defaultText,string section = "strings")
        {
            return LanguageResolver.Read(section, key, defaultText);
        }

        private void EnLoadBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                EnLoadTxt.Text = openFileDialog.FileName;
                currentFileTxt.Text = Path.GetFileName(EnLoadTxt.Text);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.LoadSettings();
            openFileDialog = new OpenFileDialog();
        }
    }
}
