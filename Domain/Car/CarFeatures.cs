namespace CarRentalSystem.Domain.Car
{
    [Flags]
    public enum CarFeatures
    {
        None = 0,
        Electric = 1 << 0,
        WithRails = 1 << 1,
        Navigation = 1 << 2,
        Sunroof = 1 << 3,
        FourWheelDrive = 1 << 4
        // Add more as needed
    }
}
