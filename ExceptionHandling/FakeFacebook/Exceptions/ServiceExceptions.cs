using System;
using System.Collections.Generic;
using System.Text;

namespace FakeFacebook.Exceptions
{
    public class ServiceExceptions : Exception
    {
        public ServiceExceptions(string message, Exception ex)
            : base(message, ex)
        {

        }
    }
}
