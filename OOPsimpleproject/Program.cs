using System.Security.Principal;

namespace OOPsimpleproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager
            {
                id = 1000,
                Name = "Ahmed A.",
                logged_Hours = 176,
                Wage = 10,

            };
            Maintenance Emp_maintainice = new Maintenance
            {
                id = 1001,
                Name = "Salim M",
                logged_Hours = 185,
                Wage = 9,
            };
            Sales sales_man = new Sales
            {
                id = 1002,
                Name = "Reem A.",
                logged_Hours = 176,
                Wage = 8,
            };
            Developer Dev_Emp = new Developer
            {
                id = 1002,
                Name = "ahmed abnaser.",
                logged_Hours = 180,
                Wage = 14,
                Task_Completed = true,


            };

            Employee[] employess = { manager, Emp_maintainice, sales_man, Dev_Emp };
            foreach (Employee employee in employess)
            {

                Console.WriteLine(employee);
                Console.WriteLine("================");

            }


        }
    }


}
