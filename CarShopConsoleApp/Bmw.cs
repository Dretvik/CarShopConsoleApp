
namespace CarShopConsoleApp
{
    internal class Bmw : Car
    {

        internal Bmw(string model, string registrationNumber, int kilometersDriven, int yearModel, int price)
        {
            Brand = "Bmw";
            Model = model;
            RegistrationNumber = registrationNumber;
            KilometersDriven = kilometersDriven;
            YearModel = yearModel;
            Price = price;
        }

    }
}
