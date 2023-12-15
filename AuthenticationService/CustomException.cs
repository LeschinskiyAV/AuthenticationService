using System;

namespace AuthenticationService
{
    public class CustomException : Exception
    {
        public CustomException(string message)
        {
            Exception exception = new Exception(message);
        }
    }
}
