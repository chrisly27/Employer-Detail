using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    [Serializable]
    class Physio : IpayableStaff
    {
        /// <summary>
        /// ================================================
        /// REMEMBER TO ADD THIS INSTANCES TO YOUR DIAGRAM
        /// ================================================
        /// </summary>
        //create instance variable/properties
        private string title;
        private string firstname;
        private string surname;
        private string NI;
        private int days_off;
        private double tax_rate;
        private double weekly_pay;

        //setting the accessors/properties
        public string Titile
        {
            get { return title; }
            set { title = value; }
        }
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string NationalInsurance
        {
            get { return NI; }
            set { NI = value; }
        }
        public string FullName
        {
            get { return title + " " + firstname + " " + surname + "\n"; }
        }
        public int DaysOff
        {
            get { return days_off; }
            set { days_off = value; }
        }
        public double TaxRate
        {
            get { return tax_rate; }
            set { tax_rate = value; }
        }
        public double WeeklyPay
        {
            get { return weekly_pay; }
            set { weekly_pay = value; }
        }

        

        //creating an empty constructor 
        public Physio()
        {
            title = "no title";
            firstname = "no nome";
            surname = "no nome";
            NI = "no NI";
            tax_rate = 0.00;
            weekly_pay = 0.00;
            days_off = 0;
        }

        //creating constructor passing param
        public Physio(string title, string firstname,
                        string surname, string NI, 
                        int days_off,
                        double tax_rate, double weekly_pay)
        {
            this.title = title;
            this.firstname = firstname;
            this.surname = surname;
            this.NI = NI;
            this.tax_rate = tax_rate;
            this.weekly_pay = weekly_pay;
            this.days_off = days_off;
        }

        //calculating the pay off from the number of days off
        public double Total_DaysOff()
        {
            double total_days_off = 3.50;
            total_days_off = total_days_off * days_off;
            return total_days_off;
        }


        public override string ToString()
        {
            return string.Format("Name: " + FullName + " - Physio");
        }


        //creating the paysalary method
        public virtual double PaySalary()
        {
            double Salary = (weekly_pay - Total_DaysOff()) - tax_rate;
            return Salary;
        }

        public string ShowDetails()
        {
            string show =   "Name: " + FullName +
                            "\nDepartment: Physio" + 
                            "\nSalary: " + PaySalary();

            return show;
        }
    }
}
