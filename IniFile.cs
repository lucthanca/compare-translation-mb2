using System.Runtime.InteropServices;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace CompareTranslatorXml
{
    class IniFile
    {
        private string filePath;
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern long WritePrivateProfileString(
            string section,
            string key,
            string val,
            string filePath
        );

        [DllImport("kernel32", EntryPoint = "GetPrivateProfileStringW", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
        private static extern int GetPrivateProfileString(
            string section,
            string key,
            string def,
            StringBuilder retVal,
            int size,
            string filePath
        );
        public IniFile(string filePath)
        {
            FileInfo file = new FileInfo(filePath);
            this.filePath = file.FullName;
            if (!file.Exists)
            {
                if (!file.Directory.Exists) file.Directory.Create();

                // Tạo file để save tiếng việt, tạo thủ công thì set encoding = UTF-16 LE
                using (FileStream fs = new FileStream(this.filePath, FileMode.Create))
                {
                    byte[] bom = new byte[2];
                    bom[0] = 0xff;
                    bom[1] = 0xfe;
                    fs.Write(bom, 0, bom.Length);
                    fs.Close();
                }
            }
        }

        public void Write(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, this.filePath);
        }

        public string Read(string section, string key)
        {
            StringBuilder SB = new StringBuilder(2048);
            int i = GetPrivateProfileString(section, key, "", SB, 255, this.filePath);
            return SB.ToString();
        }

        public bool hasValue(string section, string key)
        {
            StringBuilder SB = new StringBuilder(2048);
            int i = GetPrivateProfileString(section, key, "", SB, 255, this.filePath);

            return i != 0;
        }

        public string FilePath
        {
            get { return this.filePath; }
            set { this.filePath = value; }
        }
    }
}
