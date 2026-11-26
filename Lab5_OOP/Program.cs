namespace Lab5_OOP;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        while (true)
        {
            Console.WriteLine("\n1. Factory Method\n2. Strategy\n3. Adapter\n0. Вихід");
            switch (Console.ReadLine())
            {
                case "1": FactoryDemo.Run(); break;
                case "2": StrategyDemo.Run(); break;
                case "3": AdapterDemo.Run(); break;
                case "0": case null: return;
                default: Console.WriteLine("Невірний вибір"); break;
            }
        }
    }
}
