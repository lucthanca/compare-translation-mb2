namespace CompareTranslatorXml
{
    class StringObject
    {
        private int index;
        private string id;
        private string en;
        private string cn;
        private string vn;

        public int Index { get => index; set => index = value; }
        public string Id { get => id; set => id = value; }
        public string En { get => en; set => en = value; }
        public string Cn { get => cn; set => cn = value; }
        public string Vn { get => vn; set => vn = value; }

        public StringObject()
        {
            Id = null;
            En = null;
            Cn = null;
            Vn = null;
        }
        public StringObject(int index, string id, string en, string cn, string vn)
        {
            Index = index;
            Id = id;
            En = en;
            Cn = cn;
            Vn = vn;
        }
    }
}
