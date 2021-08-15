using System;
using System.Runtime.Serialization;

namespace E5_cs
{
    [Serializable]
   public class DimensionMisMatchException : Exception
    {
        public DimensionMisMatchException()
        {
        }

        public DimensionMisMatchException(string message) : base(message)
        {message="DimensionMisMatchException";
        }

        public DimensionMisMatchException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DimensionMisMatchException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}