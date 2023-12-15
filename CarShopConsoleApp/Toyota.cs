namespace CarShopConsoleApp
{
    internal class Toyota : Car
    {

        internal Toyota(string model, string registrationNumber, int kilometersDriven, int yearModel, int price)
        {
            Brand = "Toyota";
            Model = model;
            RegistrationNumber = registrationNumber;
            KilometersDriven = kilometersDriven;
            YearModel = yearModel;
            Price = price;
        }

    }
}