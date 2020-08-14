using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Section10_ExercicioProposto_137.Entities
{
    class Company : Client
    {
        public int EmployeesNumber { get; set; }

        public Company()
        {
        }

        public Company(string name, double yearIncomings, int employeesNumber)
            : base(name, yearIncomings)
        {
            EmployeesNumber = employeesNumber;
        }

        public override double Taxes()
        {
            if(EmployeesNumber <= 10)
            {
                return YearIncomings * 0.16;
            }
            else
            {
                return YearIncomings * 0.14;
            }              
        }

        public override string ClientInfo()
        {
            StringBuilder s1 = new StringBuilder();
            s1.AppendLine("\n\n   CLIENT INFO ");
            s1.Append("\n   Name: " + Name);
            s1.Append("\n   Year incoming: $" + YearIncomings.ToString("F2"));
            s1.Append("\n   Employees number: " + EmployeesNumber);
            s1.Append("\n   Taxe applied: $" + this.Taxes().ToString("F2"));
            return s1.ToString();
        }
    }
}
