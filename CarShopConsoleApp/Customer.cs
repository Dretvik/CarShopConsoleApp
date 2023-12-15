

namespace CarShopConsoleApp
{
    internal class Customer
    {
        internal String Name { get; set; }
        internal int Cash { get; set; }
        internal List<Car> MyCars { get; set; }

        internal Customer(int cash, List<Car> myCars)
        {
            Cash = cash;
            MyCars = myCars;
        }
        internal void ShowMyCars()
        {
            Console.Clear();
            Console.WriteLine("\nYour Cars: \n");

            for (int i = 0; i < MyCars.Count; i++)
            {
                Console.WriteLine($"Car number {i+1} details:");
                MyCars[i].ShowInfo();
                Console.WriteLine();
            }

            Console.WriteLine("Press 'Enter' to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
