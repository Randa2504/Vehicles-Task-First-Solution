namespace Vehicles
{
public abstract class Car : IVehicle
{
    public string Manufacturer { get; set;}

    public ITires Tires {get; set;}

    public Car(string manufacturer)
    {
        Manufacturer = manufacturer;
        Tires = new SummerTires((float)2.5, 50);
    }

    public void Move()
    {
        Console.WriteLine(string.Format("You are driving a car from {0}. {1}", 
        Manufacturer, Tires.GetTiresProperties()));
    }
}
}