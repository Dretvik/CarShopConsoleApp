namespace CarShopConsoleApp
{
    internal class Nissan : Car
    {

        internal Nissan(string model, string registrationNumber, int kilometersDriven, int yearModel, int price)
        {
            Brand = "Nissan";
            Model = model;
            RegistrationNumber = registrationNumber;
            KilometersDriven = kilometersDriven;
            YearModel = yearModel;
            Price = price;
        }

    }
}