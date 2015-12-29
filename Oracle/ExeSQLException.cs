using System;
using System.Runtime.Serialization;

namespace ExeSQL
{
    [Serializable]
    class ExeSQLException : Exception
    {
        public ExeSQLException() : base() { }
        public ExeSQLException(string message) : base(message) { }
        public ExeSQLException(string message, Exception inner) : base(message, inner) { }
        protected ExeSQLException(SerializationInfo info, StreamingContext context): base(info, context)
        {
        }
    }
}
