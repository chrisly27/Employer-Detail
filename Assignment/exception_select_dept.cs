using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class exception_select_dept : Exception
    {
        private static string msg = "You must select one of the Department.\n\nThank You.";

        public exception_select_dept()
            : base(msg)
        {

        }
    }
}
