using CarRentalSystem.Domain.Car;

namespace CarRentalSystem.Domain
{
    namespace CarRentalSystem.Domain
    {
        //TODO: Check if CarFeatures and CarTypes can be derived from a collection with fixed pricing details.

        /// <summary>
        /// Represents a car available for rental in the system.
        /// Data-only model; business logic should be handled in services.
        /// </summary>
        public class Car
        {
            /// <summary>
            /// The manufacturer of the car (e.g., Toyota, Ford).
            /// </summary>
            public required string Make { get; init; }

            /// <summary>
            /// The specific model of the car (e.g., Camry, Fiesta).
            /// </summary>
            public required string Model { get; init; }

            /// <summary>
            /// The unique registration or license plate number of the car.
            /// </summary>
            public required string RegistrationNumber { get; init; }

            /// <summary>
            /// The type/category of the car (e.g., Economy, SUV, Luxury).
            /// </summary>
            public required string Type { get; init; }

            /// <summary>
            /// The base rental rate per day for this car.
            /// </summary>
            public required decimal BaseRatePerDay { get; init; }

            /// <summary>
            /// Additional features that this car has, such as Electric, WithRails, Navigation, etc.
            /// Multiple features can be combined using the <see cref="CarFeatures"/> flags enum.
            /// </summary>
            public CarFeatures Features { get; init; } = CarFeatures.None;

            /// <summary>
            /// Indicates whether the car is currently available for rental.
            /// </summary>
            public bool IsAvailable { get; set; } = true;
        }
    }
}
