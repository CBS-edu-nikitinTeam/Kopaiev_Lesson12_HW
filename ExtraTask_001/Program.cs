using System;

namespace ExtraTask_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Address ad1 = new Address();
            ad1.Index = 49000; // Используем блок инициализатора -> new Address() { Index = 49000 };
            Console.WriteLine(ad1.Index);

            ad1.Country = "UK";
            ad1.City = "DP";
            ad1.Street = "Gogolya";
            ad1.House = 51;
            ad1.Apartment = 99;

            Console.WriteLine($"Full address is {ad1.Index}, {ad1.Country}, {ad1.City}, {ad1.Street} {ad1.House}, Apartment № {ad1.Apartment}");

            //Delay 
            Console.ReadKey();
        }
    }
}
