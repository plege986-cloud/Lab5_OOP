namespace Lab5_OOP;
interface IPaymentStrategy { void Pay(decimal amount); }
class CardPayment : IPaymentStrategy
{
    public void Pay(decimal amount) => Console.WriteLine($"Оплата карткою: {amount} грн");
}
class CashPayment : IPaymentStrategy
{
    public void Pay(decimal amount) => Console.WriteLine($"Оплата готівкою: {amount} грн");
}
class Checkout
{
    private IPaymentStrategy strategy;
    public Checkout(IPaymentStrategy strategy) => this.strategy = strategy;
    public void SetStrategy(IPaymentStrategy value) => strategy = value;
    public void Pay(decimal amount) => strategy.Pay(amount);
}
static class StrategyDemo
{
    public static void Run()
    {
        Checkout checkout = new Checkout(new CardPayment());
        checkout.Pay(500);
        checkout.SetStrategy(new CashPayment());
        checkout.Pay(500);
    }
}
