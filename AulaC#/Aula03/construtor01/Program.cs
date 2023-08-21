namespace construtor01;
class Program
{
    static void Main(string[] args)
    {
        //Exploração de sobrecarga
        // Data d = new Data(8,8,2023);
        // d.print();

        // Data d1=new();
        // d1.print();

        // d1=new(d);
        // d1.print();

        // d1=new(8,10,"1976");
        // d1.print();

        //Data.imprimeAlgo();

        Animal a  = new();
        Console.WriteLine(a.toString());
        a.EmiteSom();
        Console.WriteLine("--------------------");
        Gato g = new Gato("Persa");
        Console.WriteLine(g.toString());
        g.EmiteSom();
    }
}
