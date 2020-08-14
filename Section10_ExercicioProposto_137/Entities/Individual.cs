using System.Text;

namespace Section10_ExercicioProposto_137.Entities
{
    class Individual : Client
    {        
        public double HealthSpendings { get; set; }

        public Individual()
        {            
            HealthSpendings = 0.00;
        }

        public Individual(string name, double yearIncomings, double healthSpendings)
            : base(name, yearIncomings)
        {           
            HealthSpendings = healthSpendings;
        }

        public override double Taxes()
        {            
            if (this.YearIncomings < 20000.00)
            {
                return (YearIncomings * 0.15) - (HealthSpendings * 0.5);                
            }
            else
            {
                return (YearIncomings * 0.25) - (HealthSpendings * 0.5);                
            }
        }

        public override string ClientInfo()
        {
            StringBuilder s1 = new StringBuilder();
            s1.AppendLine("\n\n   CLIENT INFO ");
            s1.Append("\n   Name: " + Name);
            s1.Append("\n   Year incoming: $" + YearIncomings.ToString("F2"));
            s1.Append("\n   Health speendings: $" + HealthSpendings.ToString("F2"));
            s1.Append("\n   Taxe applied: " + this.Taxes().ToString("F2"));
            return s1.ToString();
        }
    }
}
