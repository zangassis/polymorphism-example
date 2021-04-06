using System;

namespace polymorphism_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Tax trainee = new Trainee();
            trainee.MealAllowance(1000);
            trainee.TransitPass(1000);
            Console.WriteLine("----------------------------");
            
            Tax manager = new Manager();
            manager.MealAllowance(5000);
            manager.TransitPass(5000);
            Console.WriteLine("----------------------------");

            Tax attendant = new Attendant();
            attendant.MealAllowance(2000);
            attendant.TransitPass(2000);
            Console.WriteLine("----------------------------");
        }
    }
}
