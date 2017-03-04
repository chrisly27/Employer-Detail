using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
   
    public interface IpayableStaff
    {

        /// <summary>
        /// ============================
        /// ADD THIS TO THE UML DIAGRAM
        /// ============================
        /// </summary>
        string FullName
        {
            get;
        }

        string Surname
        {
            get;
        }

        string NationalInsurance
        {
            get;
        }

        double PaySalary();

        string ShowDetails();
    }
}
