using System.Windows.Forms;

namespace CompareTranslatorXml
{
    public partial class AboutAuthorForm : Form
    {
        /// <summary>
        /// Biến dùng để phiên dịch ngôn ngữ của app theo ngôn ngữ được người dùng cài đặt
        /// </summary>
        readonly LanguageResolver translator = new LanguageResolver();

        /// <summary>
        /// Form hiển thị thông tin của ứng dụng
        /// </summary>
        public AboutAuthorForm()
        {
            InitializeComponent();
            ProcessLanguageText();
        }

        /// <summary>
        /// Tiến hành khởi tạo và thiết lập ngôn ngữ cho môi trường hiển thị app
        /// </summary>
        private void ProcessLanguageText()
        {
            #region Checkupdate button
            checkUpdateBtn.Text = translator.Translate("0026", "Kiểm tra cập nhật");
            #endregion
        }

        /// <summary>
        /// Mở trình duyệt mặc định và đi tới fb của tác giả
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FbLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.fb.com/lucthanca.me");
        }
    }
}
