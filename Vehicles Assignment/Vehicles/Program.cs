namespace Vehicles
{
class Program
{
    static void Main(string[] args)
    {
        ToyotaCar toyotaCar = new ToyotaCar();
        toyotaCar.Move();
        toyotaCar.Tires = new WinterTires(20,(float)15.6,30);
        toyotaCar.Move();
        HondaMotorcycle hondaMotorCycle = new HondaMotorcycle();
        hondaMotorCycle.Move();
        KtmMotorcycle ktmMotorcycle = new KtmMotorcycle();
        ktmMotorcycle.Move();
        HondaCar hondaCar = new HondaCar();
        hondaCar.Move();
    }
}
}