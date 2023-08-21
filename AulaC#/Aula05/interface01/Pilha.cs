public class Pilha : IPilha, IOutraCoisa, IUmaCoisa
{
    private List<object> minhaListaDeObjetos; 
    private int nElementos;

    public Pilha()
    {
        minhaListaDeObjetos = new List<object>();
        nElementos = 0;
    }

    void IUmaCoisa.metodo(){ //assim não pode usar o public 
        Console.WriteLine("Um metodo UmaCoisa");
    }

    void IOutraCoisa.metodo(){
        Console.WriteLine("Um metodo OutraCoisa");
    }

    public void Empilha(object parametro)
    {
        minhaListaDeObjetos.Add(parametro);
        nElementos++;
    }

    public object? Desempilha()
    {
        if(nElementos>0)
        {
            object aux = minhaListaDeObjetos[nElementos-1];
            minhaListaDeObjetos.RemoveAt(nElementos-1);
            nElementos--;
            return aux;
        }
        else
            return null;
    }

    public object? Topo
    {
        get
        {
            if(nElementos>0)
            {
                return minhaListaDeObjetos[nElementos-1];
            }
            else
                return null;
        }
    }

    public int qtdElementos()
    {
        return minhaListaDeObjetos.Count;
    }
}