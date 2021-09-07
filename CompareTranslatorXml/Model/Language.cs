namespace CompareTranslatorXml.Model
{
    class Language
    {
        public const string VN = "vn";
        public const string EN = "en";

        private string code;
        private string label;

        public string Code { get => code; set => code = value; }
        public string Label { get => label; set => label = value; }
    }
}
