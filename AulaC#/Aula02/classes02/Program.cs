namespace classes02;
class Program
{
    static void Main(string[] args)
    {
        //criando uma instancia
        Cliente c = new Cliente();
        Console.WriteLine(c);

        //acessando uma constante
        //Console.WriteLine(c.tipo); //causou erro de compilação
        Console.WriteLine(Cliente.tipo);

        //acessando um método da classe Cliente
        c.saudacao();
        //Cliente.saudacao(); //causou erro de compilação

        //acessando o metodo para manipulação do limite do credito
        Console.WriteLine("O limite do credito é: "+c.consultaLimite());
        Console.WriteLine("Adicionando 50 de limite");
        c.AumentarLimite(50);
        Console.WriteLine("O limite do credito é: "+c.consultaLimite());

        //explorando metodo com parametro out e ref
        int a = 10;
        int b ;

        //não é possivel pois b não foi inicializado
        /*
        Console.WriteLine("Antes da chamada do método normal");
        Console.WriteLine("O valor de a é: " +a);
        c.MetodoNormal(a, b); 
        Console.WriteLine("Depois da chamada do método normal");
        Console.WriteLine("O valor de a é: " +a);
        Console.WriteLine("O valor de b é: " +b);
        */

        Console.WriteLine("Antes da chamada do método com out");
        Console.WriteLine(" O valor de a é: " +a);
        c.MetodoOut(a, out b);
        Console.WriteLine("Depois da chamada do método com out");
        Console.WriteLine(" O valor de a é: " +a);
        Console.WriteLine(" O valor de b é: " +b);

        Console.WriteLine("Antes da chamada do método com ref");
        Console.WriteLine(" O valor de a é: " +a);
        c.MetodoRef(a, ref b);
        Console.WriteLine("Depois da chamada do método com ref");
        Console.WriteLine(" O valor de a é: " +a);
        Console.WriteLine(" O valor de b é: " +b);

        Console.WriteLine("Método com nro dinamico de parametros");
        Console.WriteLine(" Uma lista de fato");
        int [] minhaLista = new int[4] {1,2,3,4};
        c.MetodoParam(minhaLista);

        Console.WriteLine(" Chamada com N parametros");
        c.MetodoParam(5,6,7,8,9,10);


        //manipulação de propriedade
        Console.WriteLine("Manipulação de propriedades");
        Console.WriteLine("Nome do cliente é: "+c.Nome);
        c.Nome = "Carolina";
        Console.WriteLine("Nome do cliente é: "+c.Nome);
    }
}
