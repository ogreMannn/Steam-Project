using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Project.Business.Exceptions.CategoryExceptions
{
    public class CategoryNullException : Exception
    {
        public CategoryNullException() : base("Category not found") { }

        public CategoryNullException(string? message) : base(message) { }
    }
}
