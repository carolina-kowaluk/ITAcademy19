public class Funcionario: Pessoa
{
    public decimal salario{get;}
    private const decimal SALARIO_MINIMO = 1300.25M;

    public Funcionario(string nome, int idade, decimal valorSalario)
        :base(nome, idade)
    {
        this.salario = valorSalario;
    }

    public Funcionario(decimal valorSalario):this("João Ninguem", -1, valorSalario){}

    public override string? ToString(){
        string texto = base.ToString();
        texto += $" Salário: R$ {this.salario}\n";
        return texto;
    }

    public string satisfacaoSalario(){
        Random r = new();
        if(r.Next()%10<3){
            return "insatisfeito";
        }
        else{
            return "satisfeito";
        }
    }

}