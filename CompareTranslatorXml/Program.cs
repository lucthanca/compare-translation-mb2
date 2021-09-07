using System;
using System.Windows.Forms;

namespace CompareTranslatorXml
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MessageBoxManager.OK = "Alright";
            MessageBoxManager.Cancel = "Noway";
            MessageBoxManager.Register();
            MessageBox.Show("This is a message...", "Test", MessageBoxButtons.OK);
            MessageBox.Show("This is a message...", "Test", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            new OpenFileDialog().ShowDialog();
            MessageBoxManager.Unregister();
            return;
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MessageBoxManager.OK = "Testtt";
            MessageBoxManager.Yes = "ytessssss";

            MessageBoxManager.No = "con lau";
            //Register manager
            MessageBoxManager.Register();
            MessageBox.Show("12123", "123123123vafsg", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            Application.Run(new MainForm());
        }
    }
}
