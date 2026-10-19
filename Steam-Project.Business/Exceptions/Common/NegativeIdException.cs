using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Project.Business.Exceptions.Common
{
    public class NegativeIdException : Exception
    {
        public NegativeIdException() : base("Id cannot be 0 or negative") { }

        public NegativeIdException(string? message ) : base(message) { }


    }
}
