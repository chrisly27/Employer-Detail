using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class exception_blank_field : Exception
    {
        private static string msg = "You must enter a character in the field. Check the fields\n\nThank You.";

        public exception_blank_field()
            : base(msg)
        {

        }
    }
}
