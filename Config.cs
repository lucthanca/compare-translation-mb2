namespace CompareTranslatorXml
{
    class Config
    {
        public const string DEFAULT_LANG = "Vietnamese";
        public const string SETTINGS_SECTION = "Settings";
        public const string LANGUAGE_SETTING = "Language";

        public const string DEFAULT_CONFIGS_FILENAME = "Configs.ini";
        private IniFile iniFile;

        public Config(string filePath = null)
        {
            iniFile = new IniFile(filePath ?? DEFAULT_CONFIGS_FILENAME);
        }

        public void Write(string section, string key, string value)
        {
            iniFile.Write(section, key, value);
        }

        public string Read(string section, string key)
        {
            return iniFile.Read(section, key);
        }
    }
}
