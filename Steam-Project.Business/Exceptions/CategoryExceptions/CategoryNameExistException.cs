using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Project.Business.Exceptions.CategoryExceptions
{
    public class CategoryNameExistException : Exception
    {
        public CategoryNameExistException() : base("This name for category is illegit") { }

        public CategoryNameExistException(string? message) : base(message) { }
    }
}
