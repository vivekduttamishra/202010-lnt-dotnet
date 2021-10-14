using System;
using System.Runtime.Serialization;

namespace ConceptArchitect.Collections
{
    [Serializable]
    public  class StackUnderflowException : StackException
    {
        public StackUnderflowException()
        {
        }

        public StackUnderflowException(string message) : base(message)
        {
        }

        public StackUnderflowException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StackUnderflowException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}