namespace ClasseAbstrata;
class Program
{
    static void Main(string[] args)
    {
        DateTime data = new DateTime(1975, 12, 25);
        ContaPoupanca conta2 = new ContaPoupanca(20, data, "Ana Maria");
        Console.WriteLine(conta2.Id);
    }
}
