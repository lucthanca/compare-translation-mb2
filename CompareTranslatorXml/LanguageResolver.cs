using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CompareTranslatorXml
{
    class LanguageResolver: INotifyPropertyChanged
    {
        // Khai báo custom event
        public event PropertyChangedEventHandler PropertyChanged;

        public const string DEFAULT_LANGUAGE = "vn";

        private string currentLanguage;
        private static IniFile iniFile;
        private Config config;

        public string CurrentLanguage
        {
            get { return currentLanguage; }
            set
            {
                currentLanguage = value;

                OnPropertyChanged("CurrentLanguage");
            }
        }

        protected void OnPropertyChanged(string language)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(language));
        }

        /// <summary>
        /// Khởi tạo Language Resolver
        /// Kiểm tra ngôn ngữ đã được khởi tạo chưa, nếu chưa thì tiến hành khởi tạo
        /// cấu hình ngôn ngữ
        /// </summary>
        public LanguageResolver()
        {
            if (CurrentLanguage == "" || CurrentLanguage == null)
            {
                InitializeAppLanguage();
            }
        }

        /// <summary>
        /// Khởi tạo cấu hình ngôn ngữ của app
        /// </summary>
        /// <returns>trả về chính đối tượng này</returns>
        public LanguageResolver InitializeAppLanguage()
        {
            config = new Config();
            CurrentLanguage = config.GetValue(Config.LANGUAGE_KEY);
            // Ghi config mặc định, đặt lang mặc định 
            if (CurrentLanguage.Equals(""))
            {
                config.Write(Config.LANGUAGE_KEY, DEFAULT_LANGUAGE);
                CurrentLanguage = LanguageResolver.DEFAULT_LANGUAGE;
            }
            string languagePath = string.Format(@"Languages\{0}.ini", CurrentLanguage);
            SetInitFile(new IniFile(languagePath));

            return this;
        }

        /// <summary>
        /// Set biến đã đọc file ngôn ngữ
        /// </summary>
        /// <param name="file"></param>
        public void SetInitFile(IniFile file)
        {
            iniFile = file;
        }

        public string Read(string section, string key, string defaultString)
        {
            string resultStr = iniFile.Read(section, key);
            if (!resultStr.Equals("")) return resultStr;
            return defaultString;
        }

        /// <summary>
        /// Phiên dịch ngôn ngữ
        /// </summary>
        /// <param name="key">Key trong file INI theo ngôn ngữ được thiết lập, ví dụ: Vietnamese.ini</param>
        /// <param name="defaultText">Chuỗi hiển thị mặc định nếu không tìm thấy key trong file ngôn ngữ</param>
        /// <param name="section">khu vực đặt key trong file ini</param>
        /// <returns></returns>
        public string Translate(string key, string defaultText, string section = "strings")
        {
            return Read(section, key, defaultText);
        }
    }
}
