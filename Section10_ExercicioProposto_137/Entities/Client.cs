
namespace Section10_ExercicioProposto_137.Entities
{
    abstract class Client
    {
        public string Name { get; set; }
        public double YearIncomings { get; set; }

        protected Client()
        {
            Name = "Null";
            YearIncomings = 0.00;
        }

        protected Client(string name, double yearIncomings)
        {
            Name = name;
            YearIncomings = yearIncomings;
        }

        public abstract double Taxes();

        public abstract string ClientInfo();
    }
}
