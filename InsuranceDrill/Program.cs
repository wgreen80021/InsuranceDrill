using System;

namespace InsuranceDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string Age = Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI?");
            string DUI = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have? ");
            string TIX = Console.ReadLine();
            string DUIupp = DUI.ToUpper();

            bool Insurance = (Convert.ToInt32(Age) > 15 && DUIupp == "NO" && Convert.ToInt32(TIX) <= 3);

            Console.WriteLine("Do you qualify for insurance ?  ");
            Console.WriteLine(Insurance);

            Console.ReadLine();


        }
    }
}
