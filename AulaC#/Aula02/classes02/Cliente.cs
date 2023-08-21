public class Cliente
{
    public const string tipo = "Pessoa";
    private string nome;
    public string Nome{
        get{return nome;}
        set{nome=value;}
    }
    private decimal limiteCredito;
    private uint clienteID;

    public void saudacao(){
        Console.WriteLine("Ola");
    }

    public void AumentarLimite(decimal valor)
    {
        limiteCredito += valor;
    }

    public decimal consultaLimite(){
        return limiteCredito;
    }

    public void MetodoOut(int a, out int b){
        b = 200*a;
    }

    public void MetodoNormal(int a, int b){
        b = 200*a;
    }

    public void MetodoRef(int a, ref int b){
        b += a;
    }    

    public void MetodoParam(params int [] listaDeParametros){
        for (int i=0; i<listaDeParametros.Length; i++)
            Console.WriteLine("     param["+i+"]: "+listaDeParametros[i]);
    }
}