using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    [Serializable]
    public abstract class Athlete : IpayableStaff
    {
        //instance the variables/properties
        private string title;
        private string firstname;
        private string surname;
        private string nationality;
        private string NI;
        private int daysoff;
        private int DOB;
        private double taxrate;
        private double weeklypay;


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
        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }
        public string NationalInsurance
        {
            get { return NI; }
            set { NI = value; }
        }
        public int DaysOff
        {
            get { return daysoff; }
            set { daysoff = value; }
        }
        public int DateOfBirth
        {
            get { return DOB; }
            set { DOB = value; }
        }
        public double TaxRate
        {
            get { return taxrate; }
            set { taxrate = value; }
        }
        public double WeeklyPay
        {
            get { return weeklypay; }
            set { weeklypay = value; }
        }

        public string FullName
        {
            get { return title + " " + firstname + " " + surname; }
        }

        //creating an empty constructor 
        public Athlete()
        {
            title = "no title";
            firstname = "no nome";
            surname = "no nome";
            nationality = "no nationality";
            NI = "no NI";
            DOB = 0;
            taxrate = 0.00;
            weeklypay = 0.00;
            daysoff = 0;
        }

        //creating constructor passing param
        public Athlete(string title, string firstname, 
                        string surname, string nationality, 
                        string NI, int daysoff, int DOB, 
                        double taxrate, double weeklypay)
        {
            this.title = title;
            this.firstname = firstname;
            this.surname = surname;
            this.nationality = nationality;
            this.NI = NI;
            this.DOB = DOB;
            this.taxrate = taxrate;
            this.weeklypay = weeklypay;
            this.daysoff = daysoff;
        }

        //calculating the pay off from the number of days off
        public double TotalDaysOff()
        {
            double total_days_off = 5.50;
            total_days_off = total_days_off * daysoff;
            return total_days_off;
        }

        //creating the paysalary method
        public  virtual double PaySalary()
        {
            double Salary = (weeklypay - TotalDaysOff()) - taxrate;
            return Salary;
        }


        public override string ToString()
        {
            return string.Format("Name: " + FullName + " - None");
        }


        public virtual string ShowDetails()
        {
            string show =   "Name: " + FullName + 
                            "\n" +
                            "\nDepartment: none" + 
                            "\nSalary: " + PaySalary();

            return show;
        }

    }

    //Child Class - Footballers
    [Serializable]
    class Footballers : Athlete, IpayableStaff
    {
        //instance the variables/properties
        private string team;
        private string position;
        private int shirt_no;
        private double fines;

        //setting the accessors/properties
        public string Team
        {
            get { return team; }
            set { team = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public int Shirt_Number
        {
            get { return shirt_no; }
            set { shirt_no = value; }
        }
        public double Fines
        {
            get { return fines; }
            set { fines = value; }
        }

        //creating constructor passing param
        public Footballers( string title, string firstname,
                            string surname, string nationality,
                            string NI, int daysoff, int DOB,
                            double taxrate, double weeklypay,
                            string team, string position,
                            int shirt_no, double fines)
                :base (title, firstname, surname, nationality,
                        NI,daysoff, DOB, taxrate, weeklypay)
        {
            this.team = team;
            this.position = position;
            this.shirt_no = shirt_no;
            this.fines = fines;
        }

        public double Total_Fines()
        {
            double total_fines = 0.00;
            total_fines = total_fines + fines;
            return total_fines;
        }

        public override string ToString()
        {
            return string.Format("Name: " + FullName + " - Footballer");
        }

        public override string ShowDetails()
        {
            string details = "Name: " + FullName
                            + "\n"
                            + "\nDepartment: Footballer"
                            + "\nSalary: " + PaySalary()
                            + "\nD.O.B: " + DateOfBirth
                            + "\nTeam: " + Team
                            + "\nPosition: " + Position
                            + "\nShirt n: " + Shirt_Number
                            + "\nNationality: " + Nationality;
            return details;
        }

    }

    [Serializable]
    class Swimmers: Athlete, IpayableStaff
    {
        private string resident;
        private string events;
        private string coach;

        public string Resident
        {
            get { return resident; }
            set { resident = value; }
        }

        public string Events
        {
            get { return events; }
            set { resident = value; }
        }

        public string Coach
        {
            get { return coach; }
            set { coach = value; }
        }


        //creating constructor passing param
        public Swimmers(string title, string firstname,
                            string surname, string nationality,
                            string NI, int daysoff, int DOB,
                            double taxrate, double weeklypay,
                            string resident, string events,
                            string coach)
                :base (title, firstname, surname, nationality,
                        NI,daysoff, DOB, taxrate, weeklypay)


        {
            this.resident = resident;
            this.events = events;
            this.coach = coach;
        }


        public override string ToString()
        {
            return string.Format("Name: " + FullName + " - Swimmer");
        }

        public override string ShowDetails()
        {
            string show = "Name: " + FullName
                            + "\n"
                            + "\nDepartment: Swimmer"
                            + "\nSalary: " + PaySalary()
                            + "\nD.O.B: " + DateOfBirth
                            + "\nResident: " + Resident
                            + "\nNationality: " + Nationality;

            return show;
        }
    }
}
