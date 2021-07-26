using System.Collections.Generic;
using CompareTranslatorXml.Model;

namespace CompareTranslatorXml
{
    class Config
    {
        public const string DEFAULT_CONFIGS_FILENAME = "Configs.ini";

        public const string SETTINGS_SECTION = "Settings";

        public const string LANGUAGE_KEY = "Language";
        public const string ENABLE_AUTO_SAVE_KEY = "AutoSave";
        public const string AUTO_SAVE_TYPE_KEY = "AutoSaveType";
        public const string IDLE_TIME = "AutoSaveTypeIdleTime";

        private IniFile iniFile;
        private Dictionary<string, object> defaultConfigs = new Dictionary<string, object>()
        {
            {LANGUAGE_KEY, LanguageResolver.DEFAULT_LANGUAGE},
            {ENABLE_AUTO_SAVE_KEY, "True"},
            {AUTO_SAVE_TYPE_KEY, AutoSaveType.END_EDIT},
            {IDLE_TIME, 15}
        };

        public Config(string filePath = null)
        {
            iniFile = new IniFile(filePath ?? DEFAULT_CONFIGS_FILENAME);
        }

        /// <summary>
        /// Ghi vào file *.ini được định nghĩa
        /// </summary>
        /// <param name="key">key. Ví dụ: Language</param>
        /// <param name="value">giá trị lưu: ví dụ vn</param>
        /// <param name="section">khu vực lưu, ví dụ: Settings</param>
        public void Write(string key, string value, string section = SETTINGS_SECTION)
        {
            iniFile.Write(section, key, value);
        }

        /// <summary>
        /// Đọc giá trị trong file *.ini khi khởi tạo đối tượng
        /// </summary>
        /// <param name="section">khu vực đọc. Ví dụ: Settings</param>
        /// <param name="key">Key cần đọc. Ví dụ: Language</param>
        /// <returns></returns>
        public string Read(string section, string key)
        {
            return iniFile.Read(section, key);
        }

        /// <summary>
        /// Lấy ra giá trị cấu hình của một section và 1 key đưa vào
        /// </summary>
        /// <param name="key"></param>
        /// <param name="section"></param>
        /// <returns></returns>
        public string GetValue(string key, string section = SETTINGS_SECTION)
        {
            string value = Read(section, key);
            if (string.IsNullOrEmpty(value))
                return defaultConfigs[key].ToString();
            return value;
        }
    }
}
