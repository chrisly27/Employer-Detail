using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    /// <summary>
    /// ===========================================================
    /// THINK ABOUT THE ATTRIBUTES AND METHODS YOU NEED TO ADD HERE
    /// ===========================================================
    /// </summary>
    
    [Serializable]
    public class HR //: IpayableStaff
    {
        /*

        public double PaySalary()
        {
            double pay = 0.0;

            return pay;
        }

        public string FullName
        {
            get;
        }

        public string Surname
        {
            get;
        }

        public string NationalInsurance
        {
            get;
        }





        public List<IpayableStaff> emp;

        public HR()
        {
            emp = new List<IpayableStaff>();
        }

        public bool AddEmp(IpayableStaff emplo)
        {
            bool success = true;
            foreach (IpayableStaff s in emp)
            {
                if (s.FullName == emplo.FullName)
                {
                    success = false;
                }
            }

            if (success)
            {
                emp.Add(emplo);
            }
            return success;
        }

        public IpayableStaff Find(string searchFullname)
        {
            IpayableStaff staff = null;
            foreach (IpayableStaff s in emp)
            {
                if (s.FullName == searchFullname)
                {
                    staff = s;
                }
            }
            return staff;
        }



        public string ShowDetails()
        {
            string msg = "";

            string cr = Environment.NewLine;

            foreach (IpayableStaff s in emp)
            {
                msg += string.Format("{0} {1}{2}", s.FullName, s.NationalInsurance, cr);
            }

            return msg;
        }
        */
    }
}
