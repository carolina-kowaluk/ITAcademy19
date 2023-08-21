public class Pessoa
{
    public string nome;
    public int idade{get; private set;} //propriedade: publico somente para leitura, não pode ser editado
    public int anoNascimento{ //peopriedade
        get{
            DateTime hoje = DateTime.Now; //data atual
            return hoje.Year - this.idade;
        }
        set{
            this.idade=DateTime.Now.Year-value;
        }
    }

    //public Pessoa():this("João Ninguem",-1){}

    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    public override string? ToString(){
        string texto;
        texto = "/===============\n";
        texto +=$"   Nome      : {this.nome}\n";
        texto +=$"   Idade     : {this.idade}\n";
        texto +=$"   Nascimento: {this.anoNascimento}\n";
        texto += "/===============\n";
        return texto;
    }

    public string humor(){
        Random r = new Random();
        switch (r.Next(3))
        {
            case 0: return "alegre";
            case 1: return "feliz";
            case 2: return "contente";
            default:return "apatico";
        }
    }

}