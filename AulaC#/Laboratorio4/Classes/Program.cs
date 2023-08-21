namespace Classes;
class Program
{
    static void Main(string[] args)
    {
        ContaCorrente minhaConta = new ContaCorrente("Carolina");
        Console.WriteLine(minhaConta.Saldo); 
        minhaConta.Depositar(100); 
        Console.WriteLine(minhaConta.Saldo);
        minhaConta.Sacar(50); 
        Console.WriteLine(minhaConta.Saldo);
        Console.WriteLine(minhaConta.Data);
        Console.WriteLine("Média do saldo: "+minhaConta.MediaSaldo());
    }
}
