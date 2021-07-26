namespace CompareTranslatorXml.Model
{
    class AutoSaveType
    {
        public const int IDLE = 1;
        public const int END_EDIT = 2;

        private string label;
        private int value;

        public string Label { get => label; set => label = value; }
        public int Value { get => value; set => this.value = value; }

        public AutoSaveType()
        {
            label = null;
            value = 0;
        }

        public AutoSaveType(int value, string label)
        {
            Label = label;
            Value = value;
        }
    }
}
