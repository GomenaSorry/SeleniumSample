using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSample.CustomException
{
    public class ElementTextMismatchException : Exception
    {
        public ElementTextMismatchException(string msg) : base(msg)
        {

        }
    }
}
