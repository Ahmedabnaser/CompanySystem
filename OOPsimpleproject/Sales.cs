namespace OOPsimpleproject
{
    class Sales :Employee
    {
        public decimal Volume_sale { get; set; }
        public decimal Commission { get; set; }
        protected override decimal Calculate()
        {
            return base.Calculate()+ CalculateBonus();
        }
        private decimal CalculateBonus()
        {
            return Volume_sale * Commission;
        }
        public override string ToString()
        {
            return base.ToString()+$"\nBonus - {CalculateBonus()}"+
                $"\nCommission : {Commission}"+
                $"\nNet_salary : {this.Calculate()}";
        }

    }
    
}
