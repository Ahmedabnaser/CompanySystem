namespace OOPsimpleproject
{
    class Developer : Employee
    {
        public int logged_hours { get; set; }
        //public int  { get; set; }

        public bool Task_Completed { get; set; }
        private const decimal BonusRate = 0.10m;
        private decimal calculateBase()
        {
            return Wage * logged_hours;
        }

        private decimal CalculateBonus()
        {
            if (Task_Completed)
            {
                return calculateBase()*BonusRate;
            }
            else
            {
                return 0;
            }
        }

        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateBonus();
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nTask_Completed : {(Task_Completed ? "YES" : "NO")}" +
                $"\nBonus : {BonusRate}" +
                $"\nNet_Salary : {this.Calculate()}";
        }
    }
}
