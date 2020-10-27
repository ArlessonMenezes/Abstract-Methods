namespace MetodosAbsratosExe2.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) 
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double Tax()
        {
            double sum = 0.0;
            if (AnualIncome < 20000.00)
            {
                sum += (AnualIncome * 15.0 / 100.0) - (HealthExpenditures * 50.0 / 100.0);
            }
            else
            {
                sum += (AnualIncome * 25.0 / 100.0) - (HealthExpenditures * 50.0 / 100.0);
            }
            return sum;
        }
        
    }
}
