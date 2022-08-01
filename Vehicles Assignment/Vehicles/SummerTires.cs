namespace Vehicles
{
    public class SummerTires : ITires
    {
        public float Pressure {get; set;}
        public float MaximumTemperature {get; set;}

        public SummerTires(float pressure, float maximumTemperature)
        {
            Pressure = pressure;
            MaximumTemperature = maximumTemperature;
        }

        public string GetTiresProperties()
        {
            return string.Format("Tires are summer tires, pressure is {0} bar and maximum temprature is {1}°C", Pressure, MaximumTemperature);
        }
    }
}