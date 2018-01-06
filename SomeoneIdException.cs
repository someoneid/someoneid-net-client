using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SomeoneId.Net
{
    public class SomeoneIdException : Exception
    {

        private int statusCode;
        public int StatusCode
        {
            set { statusCode = value; }
            get { return statusCode; }
        }

        public SomeoneIdException(int statusCode, string message) : base(message)
        {
            this.StatusCode = statusCode;
        }
    }
}
