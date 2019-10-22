using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_Coursework.Exceptions
{
    public class InvalidLoginException : Exception
    {
        public InvalidLoginException() : base()
        {
            //custom exception constructor
        }
    }
}
