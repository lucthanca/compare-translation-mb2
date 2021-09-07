using CoreEventArgs = System.EventArgs;

namespace CompareTranslatorXml.EventArguments
{
    class LanguageEventArg: CoreEventArgs
    {
        public string Language { set; get; }
    }
}
