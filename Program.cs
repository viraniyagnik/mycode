using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String F_name, L_name, B_date;
            Console.Write("Enter first name : ");
            F_name = Console.ReadLine();
            Console.Write("Enter last name : ");
            L_name = Console.ReadLine();
            Console.Write("Enter date of birth : ");
            B_date = Console.ReadLine();
            Console.WriteLine(F_name+ " , " +L_name+ " , " +B_date);
        }
    }
}
