namespace CarRentalSystem.Services
{
    public class PricingService
    {
        //TODO: Implement a pricing service that calculates rental prices based on car type, features, and rental duration. Basics are provided, but you can expand it with more complex logic as needed.

        public decimal CalculateRentalPrice(Car car, int rentalDays)
        {
            decimal price = car.BaseRatePerDay * rentalDays;

            // Adjust price based on car type
            switch (car.Type)
            {
                case CarType.Economy:
                    price *= 1.0m;
                    break;
                case CarType.SUV:
                    price *= 1.3m;
                    break;
                case CarType.Luxury:
                    price *= 1.7m;
                    break;
            }

            // Adjust price for features
            if ((car.Features & CarFeatures.Electric) == CarFeatures.Electric)
                price += 10m * rentalDays; // Example: surcharge for electric

            if ((car.Features & CarFeatures.Navigation) == CarFeatures.Navigation)
                price += 5m * rentalDays;

            if ((car.Features & CarFeatures.FourWheelDrive) == CarFeatures.FourWheelDrive)
                price += 7m * rentalDays;

            return price;
        }
    }
}
