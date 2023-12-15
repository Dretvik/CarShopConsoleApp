namespace CarShopConsoleApp
{
    internal class Program
    {
        internal Shop shop;
        internal Customer customer;

        internal Program()
        {
            shop = new Shop(0, new List<Car>());
            customer = new Customer( 500000, new List<Car>());
            List<Car> carsInShop = new List<Car>
            {
                new Bmw("X5", "AX 20746", 20000, 2022, 500000),
                new Bmw("X4", "AX 25646", 150000, 2012, 40000),
                new Toyota("Yaris", "MK 08472", 99000, 2011, 35000),
                new Nissan("Leaf", "EL 30664", 110000, 2011, 52000),
            };
            shop.CarsInShop.AddRange(carsInShop);

        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        internal void Run()
        {

            Console.WriteLine("Please enter your name:");
            customer.Name = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"Hello {customer.Name} and welcome to Ellie's Car Shop!");
            Console.WriteLine("What do you want to do?");

            while (true)
            {
                Console.WriteLine("1. Look at cars in the shop \n2. Look at your cars\n3. Buy a car\n0. Exit Program..");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        shop.ShowCarsInShop();
                        break;
                    case "2":
                        Console.Clear();
                        customer.ShowMyCars();
                        break;
                    case "3":
                        Console.Clear();
                        BuyCar();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again..");
                        break;
                }
            }
        }
        internal void BuyCar()
        {
            Console.Clear();
            Console.WriteLine("\nCars in shop:\n");
            Console.WriteLine($"Your cash balance: {customer.Cash},-");
            for (int i = 0; i < shop.CarsInShop.Count; i++)
            {
                Console.WriteLine($"Car number {i + 1} details:");
                shop.CarsInShop[i].ShowInfo();
                Console.WriteLine();
            }

            Console.WriteLine("Enter the number of the car you want to buy:");
            if (int.TryParse(Console.ReadLine(), out int carIndex))
            {
                shop.SellCarToCustomer(customer, carIndex-1);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid car number.");
            }
        }
    }
}
