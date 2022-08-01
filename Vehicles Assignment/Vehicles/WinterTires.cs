namespace Vehicles
{
    public class WinterTires : ITires
    {
        public float Pressure {get; set;}
        public float Thickness {get; set;}
        public float MinimumTemperature {get; set;}

        public WinterTires(float pressure, float thickness, float minimumTemperature)
        {
            Pressure = pressure;
            Thickness = thickness;
            MinimumTemperature = minimumTemperature;
        }

        public string GetTiresProperties()
        {
            return string.Format("Tires are winter tires, pressure is {0} bar, thickness is {1} cm and minimum temprature is {2}°C", Pressure, Thickness, MinimumTemperature);
        }
    }
}