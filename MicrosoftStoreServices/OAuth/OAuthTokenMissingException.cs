using System;

namespace WindowsStoreServices.OAuth
{
    public class OAuthTokenMissingException : Exception
    {
        public OAuthTokenMissingException()
        {
        }

        public OAuthTokenMissingException(string message) : base(message)
        {
        }

        public OAuthTokenMissingException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
