using System;
using System.Runtime.Serialization;

namespace ClearFolder
{
    [Serializable]
    internal class SystemExpection : Exception
    {
        public SystemExpection()
        {
        }

        public SystemExpection(string message) : base(message)
        {
        }

        public SystemExpection(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SystemExpection(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}