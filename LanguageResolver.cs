using System;
using System.Collections.Generic;
using System.Text;

namespace CompareTranslatorXml
{
    class LanguageResolver
    {
        private IniFile iniFile;
        public LanguageResolver(string language)
        {
            string languagePath = string.Format(@"Languages\{0}.ini", language);
            iniFile = new IniFile(languagePath);
        }

        public string Read(string section, string key, string defaultString)
        {
            string resultStr = iniFile.Read(section, key);
            if (!resultStr.Equals("")) return resultStr;
            return defaultString;
        }
    }
}
