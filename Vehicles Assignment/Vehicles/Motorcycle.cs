namespace Vehicles
{
public abstract class Motorcycle : IVehicle
{
    public string Manufacturer { get; set;}

    public Motorcycle(string manufacturer)
    {
        Manufacturer = manufacturer;
    }

    public void Move()
    {
        Console.WriteLine("You are driving a motorcycle from " + Manufacturer);
    }
}
}

