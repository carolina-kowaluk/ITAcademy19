//namespace ColecoesGenericas;
namespace System.Collections.Generics;
class Program
{
    static void Main(string[] args)
    {
        // criando uma lista
        List<string> listaStrings = new List<string>();
        listaStrings.Add("Um");
        listaStrings.Add("Hello");
        listaStrings.Add("World");
        Console.WriteLine(listaStrings[0]);
        Console.WriteLine(listaStrings[1]);
        Console.WriteLine(listaStrings[2]);
        //listaStrings.Add(10);

        // criando uma fila de objetos
        Queue<Object> q = new Queue<Object>();
        q.Enqueue(".Net Framework");
        q.Enqueue(new Decimal(123.456));
        q.Enqueue(654.321);
        Console.WriteLine(q.Dequeue());
        Console.WriteLine(q.Dequeue());
        Console.WriteLine(q.Dequeue());

        // criando fila de inteiros
        Queue<int> minhaFila = new Queue<int>();
        minhaFila.Enqueue(10);
        minhaFila.Enqueue(200);
        minhaFila.Enqueue(1000);
        Console.WriteLine(minhaFila.Dequeue());
        Console.WriteLine(minhaFila.Dequeue());
        Console.WriteLine(minhaFila.Dequeue());

        // KeyValuePair<int,string>
        // a lista das chaves e seus respectivos valores armazenados no dicionário
        Dictionary<int, string> paises = new Dictionary<int, string>();
        paises[44] = "Reino Unido";
        paises[33] = "França";
        paises[55] = "Brasil";
        Console.WriteLine("O código 55 é: {0}", paises[55]);
        foreach (var item in paises)
        {
            int codigo = item.Key;
            string pais = item.Value;
            Console.WriteLine("Código {0} = {1}", codigo, pais);
        }
    }
}
