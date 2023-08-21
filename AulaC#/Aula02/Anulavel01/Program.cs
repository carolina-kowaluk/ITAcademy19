namespace Anulavel01;
class Program
{
    static void Main(string[] args)
    {
        string first = "test";
        string secound = string.Empty;
        int third = 3;
        DateTime? data = null;

        Console.WriteLine("first: "+first);
        Console.WriteLine("secound: "+secound);
        Console.WriteLine("third: "+third);
        Console.WriteLine("data: "+data);

        //podem dar resultados diferentes dependendo do tipo de dado utilizado
        int? v1 = 0; //0
        int? v2 = null;
        int? v3 = default;
        int? v4 = new(); //0

        Console.WriteLine("v1: "+v1);
        Console.WriteLine("v2: "+v2);
        Console.WriteLine("v3: "+v3);
        Console.WriteLine("v4: "+v4);

        //exemplo
        /// <sumary>
        /// Documentação
        /// </summary>


    }
}
