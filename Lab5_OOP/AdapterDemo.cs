namespace Lab5_OOP;
interface IPayment { void Pay(decimal hryvnias); }
class LegacyPayment
{
    public void Charge(int kopiyky) => Console.WriteLine($"Стара система: {kopiyky} коп.");
}
class PaymentAdapter : IPayment
{
    private readonly LegacyPayment legacy;
    public PaymentAdapter(LegacyPayment legacy) => this.legacy = legacy;
    public void Pay(decimal hryvnias)
    {
        legacy.Charge(checked((int)Math.Round(hryvnias * 100, MidpointRounding.AwayFromZero)));
    }
}
static class AdapterDemo
{
    public static void Run()
    {
        IPayment payment = new PaymentAdapter(new LegacyPayment());
        payment.Pay(125.50m);
    }
}
