using System;
using System.Runtime.Serialization;

namespace Sinsoft.Alejo
{
    public class UserNotFoundException : Exception
    {
        private string _userName;

        public string UserName { get { return _userName; } }

        protected UserNotFoundException() : base() { }

        public UserNotFoundException(string value) : base(string.Format("The username {0} was not found.", value))
        {
            _userName = value;
        }

        public UserNotFoundException(string value, string message) : base(message)
        {
            _userName = value;
        }

        public UserNotFoundException(string value, string message, Exception innerException) : base(message, innerException)
        {
            _userName = value;
        }

        protected UserNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
