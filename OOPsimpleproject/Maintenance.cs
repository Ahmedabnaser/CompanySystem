namespace OOPsimpleproject
{
    class Maintenance :Employee
    {
        private const int hardshipAllowance = 100;
        protected override decimal Calculate()
        {
            return base.Calculate()+ hardshipAllowance;
        }
        public override string ToString()
        {
            return base.ToString()+
                $"\nhardship : {hardshipAllowance}"+
                $"Net_salary : {this.Calculate()}";
        }


    }
    
}
