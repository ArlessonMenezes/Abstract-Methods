namespace MetodosAbsratosExe2.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) 
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double sum = 0.0;
            if(NumberOfEmployees > 10)
            {
                sum += AnualIncome * 14.0 / 100;
            }
            else
            {
                sum += AnualIncome * 16.0 / 100;
            }
            return sum;
        }
    }
}
