using System;
using CoreEventArgs = System.EventArgs;
using CompareTranslatorXml.EventArguments;

namespace CompareTranslatorXml
{
    class LanguageResolver
    {
        // Khai báo custom event
        // public event PropertyChangedEventHandler PropertyChanged;
        public static event EventHandler ChangeLanguage;

        public const string DEFAULT_LANGUAGE = "vn";

        private static string currentLanguage;
        private static IniFile iniFile;
        readonly private Config config = new Config();

        public static string CurrentLanguage
        {
            get { return currentLanguage; }
            set
            {
                currentLanguage = value;
                RefreshIniLanguageFile();
                OnLanguageChanged("CurrentLanguage", new LanguageEventArg() { Language = value });
            }
        }

        /// <summary>
        /// Trigger các subscriber event method
        /// </summary>
        /// <param name="language"></param>
        private static void OnLanguageChanged(string language, CoreEventArgs e)
        {
            ChangeLanguage?.Invoke(language, e);
        }

        /// <summary>
        /// Khởi tạo Language Resolver
        /// Kiểm tra ngôn ngữ đã được khởi tạo chưa, nếu chưa thì tiến hành khởi tạo
        /// cấu hình ngôn ngữ
        /// </summary>
        public LanguageResolver()
        {
            if (string.IsNullOrEmpty(CurrentLanguage))
            {
                InitializeAppLanguage();
            }
        }

        /// <summary>
        /// Khởi tạo cấu hình ngôn ngữ của app
        /// </summary>
        /// <returns>trả về chính đối tượng này</returns>
        public LanguageResolver InitializeAppLanguage(bool force = false)
        {
            if (force)
            {
                CurrentLanguage = config.GetValue(Config.LANGUAGE_KEY);
            } else if (string.IsNullOrEmpty(CurrentLanguage))
            {
                CurrentLanguage = config.GetValue(Config.LANGUAGE_KEY);
            }

            return this;
        }

        /// <summary>
        /// Thiết lập lại đường dẫn file ngôn ngữ dựa vào ngôn ngữ hiện tại được chọn
        /// </summary>
        private static void RefreshIniLanguageFile()
        {
            string languagePath = $@"Languages\{CurrentLanguage}.ini";
            iniFile = new IniFile(languagePath);
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
            string resultStr = iniFile.Read(section, key);
            if (!resultStr.Equals("")) return resultStr;
            return defaultText;
        }
    }
}
