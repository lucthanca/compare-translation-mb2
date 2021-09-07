namespace CompareTranslatorXml
{
    class MixedValue
    {
        private object _value;

        public MixedValue(object value) { _value = value; }
        public MixedValue(string value) { _value = value; }
        public MixedValue(int value) { _value = value; }
        public MixedValue(double value) { _value = value; }
        public MixedValue(long value) { _value = value; }
        public object GetValue() { return _value; }
    }
}
