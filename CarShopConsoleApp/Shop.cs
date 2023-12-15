using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopConsoleApp
{
    internal class Shop
    {
        internal int Cash { get; set; }
        internal List<Car> CarsInShop { get; set; }

        public Shop(int cash, List<Car> carsInShop)
        {
            Cash = cash;
            CarsInShop = carsInShop;
        }

        internal void ShowCarsInShop()
        {
            Console.Clear();
            Console.WriteLine("\nCars in shop:\n");

            for (int i = 0; i < CarsInShop.Count; i++)
            {
                Console.WriteLine($"Car number {i+1} details:");
                CarsInShop[i].ShowInfo();
                Console.WriteLine();
            }

            Console.WriteLine("Press 'Enter' to continue...");
            Console.ReadLine();
            Console.Clear();
        }
        internal void SellCarToCustomer(Customer customer, int carIndex)
        {
            if (carIndex >= 0 && carIndex < CarsInShop.Count)
            {
                Car soldCar = CarsInShop[carIndex];
                if (customer.Cash >= soldCar.Price)
                {
                    customer.MyCars.Add(soldCar);
                    customer.Cash -= soldCar.Price;
                    Cash += soldCar.Price;
                    CarsInShop.RemoveAt(carIndex);

                    Console.WriteLine($"Car sold to {customer.Name}. Press 'Enter' to continue...");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Customer does not have enough cash to buy this car. Press 'Enter' to continue...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Invalid car index. Press 'Enter' to continue...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }

}
