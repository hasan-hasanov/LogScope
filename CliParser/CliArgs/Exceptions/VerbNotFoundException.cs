using System.Runtime.Serialization;

namespace CliParser.CliArgs.Exceptions
{
    public class VerbNotFoundException : Exception
    {
        public VerbNotFoundException()
        {
        }

        public VerbNotFoundException(string message) : base(message)
        {
        }

        public VerbNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected VerbNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
