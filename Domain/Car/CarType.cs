namespace CarRentalSystem.Domain.Car
{
    /// <summary>
    /// Represents the main category or type of a car available for rental.
    /// Used to classify cars for pricing, filtering, and selection.
    /// </summary>
    public enum CarType
    {
        /// <summary>
        /// Small, fuel-efficient, and affordable cars.
        /// </summary>
        Economy,

        /// <summary>
        /// Slightly larger than economy, still efficient and compact.
        /// </summary>
        Compact,

        /// <summary>
        /// Midsize cars offering more space and comfort.
        /// </summary>
        Midsize,

        /// <summary>
        /// Sport Utility Vehicles, offering more space and off-road capability.
        /// </summary>
        SUV,

        /// <summary>
        /// High-end, premium cars with luxury features.
        /// </summary>
        Luxury
    }
}
