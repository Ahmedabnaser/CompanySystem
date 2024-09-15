namespace OOPsimpleproject
{
    class Employee
    {
        public const int Minimum_hours = 176;
        public int id { get; set; }
        public string Name { get; set; }
        public decimal Wage { get; set; }
        public int logged_Hours { get; set; }
        protected virtual decimal Calculate()
        {
            var res = CalculateBaseSalary() + CalculateOvertime();
            return res ;
        }
         private decimal CalculateBaseSalary()
        {
            return logged_Hours * Wage;
        }
        private decimal CalculateOvertime()
        {
            var additional_Hours = (logged_Hours - Minimum_hours) > 0 ? logged_Hours - Minimum_hours : 0;
            return additional_Hours * 1.25m * Wage;
        }
       
        public override string ToString()
        {
            var type= GetType().ToString().Replace("OOPsimpleproject.","");
            return $"{type}"+
                $"\nID: {id}" +
                $"\nname: {Name}" +
                $"\nWage: {Wage} hr" +
                $"\novertime: {CalculateOvertime()} " +
                $"\nNet_Salary: {Calculate()}" +
                $"\nBasic_Salary: {CalculateBaseSalary()}" +
                $"\nlogged_Hours: {logged_Hours}";

        }

    }
    
}
