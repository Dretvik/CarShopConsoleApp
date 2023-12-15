namespace CarShopConsoleApp
{
    internal abstract class Car
    {
        internal string Brand { get; set; }
        internal string Model { get; set; }
        internal string RegistrationNumber { get; set; }
        internal int KilometersDriven { get; set; }
        internal int YearModel { get; set; }
        internal int Price { get; set; }

        protected Car(string brand, string model, string registrationNumber, int kilometersDriven, int yearModel, int price)
        {
            Brand = brand;
            Model = model;
            RegistrationNumber = registrationNumber;
            KilometersDriven = kilometersDriven;
            YearModel = yearModel;
            Price = price;
        }
        public Car()
        {
            
        }

        internal void ShowInfo()
        {
            Console.WriteLine($"Brand              : {Brand}");
            Console.WriteLine($"Model              : {Model}");
            Console.WriteLine($"Reg Number         : {RegistrationNumber}");
            Console.WriteLine($"Year Model         : {YearModel}");
            Console.WriteLine($"Kilometers driven  : {KilometersDriven}");
            Console.WriteLine($"Price              : {Price}Kr");
        }
    }
}
