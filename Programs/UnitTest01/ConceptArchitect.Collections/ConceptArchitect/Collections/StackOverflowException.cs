using System;
using System.Runtime.Serialization;

namespace ConceptArchitect.Collections
{
    [Serializable]
    public class StackOverflowException : StackException
    {
        public object Value { get; private set; }

        public StackOverflowException()
        {
        }

        public StackOverflowException(object value,string message="Stack Overflow"):base(message)
        {
            this.Value = value;
        }

        public StackOverflowException(string message) : base(message)
        {
        }

        public StackOverflowException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StackOverflowException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}