using System;

namespace CompareTranslatorXml.Exceptions
{
    class NotSupportException: Exception
    {
        public NotSupportException() { }

        public NotSupportException(string message) : base(message) { }

        public NotSupportException(string msg, Exception e) : base(msg,e) { }
    }
}
