namespace OOPsimpleproject
{
    class Manager :Employee
    {
        public const decimal Allowancerate = 0.05m;
        protected override decimal Calculate()
        {
            return base.Calculate()+ CalculateAllowance();
        }
        private decimal CalculateAllowance()
        {
            return base.Calculate() * Allowancerate;
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\nAllowance ${CalculateAllowance()}" +
                $"\nNet Salary :${this.Calculate()}";
        }
    }
    
}
