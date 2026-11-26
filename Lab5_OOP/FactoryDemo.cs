namespace Lab5_OOP;
interface ITransport { void Deliver(); }
class Truck : ITransport { public void Deliver() => Console.WriteLine("Доставка вантажівкою"); }
class Ship : ITransport { public void Deliver() => Console.WriteLine("Доставка кораблем"); }
abstract class Logistics
{
    public abstract ITransport CreateTransport();
    public void PlanDelivery() => CreateTransport().Deliver();
}
class RoadLogistics : Logistics
{
    public override ITransport CreateTransport() => new Truck();
}
class SeaLogistics : Logistics
{
    public override ITransport CreateTransport() => new Ship();
}
static class FactoryDemo
{
    public static void Run()
    {
        Logistics road = new RoadLogistics();
        Logistics sea = new SeaLogistics();
        road.PlanDelivery();
        sea.PlanDelivery();
    }
}
