using System;

namespace CompareTranslatorXml
{
    class StringObject
    {
        private int index;
        private string id;
        private string en;
        private string cn;
        private string vn;
        private string originVn;
        private bool hasChanged;

        public int Index { get => index; set => index = value; }
        public string Id { get => id; set => id = value; }
        public string En { get => en; set => en = value; }
        public string Cn { get => cn; set => cn = value; }
        public string Vn { get => vn; set => vn = value; }
        public string OriginVn { get => originVn; set => originVn = value; }
        public bool HasChanged { get => hasChanged; set => hasChanged = value; }

        public StringObject()
        {
            Id = null;
            En = null;
            Cn = null;
            Vn = null;
            HasChanged = false;
        }
        public StringObject(int index, string id, string en = null, string cn = null, string vn = null, bool hasChanged = false)
        {
            Index = index;
            Id = id;
            En = en;
            Cn = cn;
            Vn = vn;
            HasChanged = hasChanged;
        }

        public void SetData(string key, MixedValue value)
        {
            try
            {
                GetType().GetProperty(key).SetValue(this, value.GetValue());
            }
            catch (Exception) { }
        }
    }
}
