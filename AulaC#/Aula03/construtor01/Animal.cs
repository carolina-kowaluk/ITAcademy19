public class Animal{
    private decimal peso;
    private int ano;
    private decimal altura;
    private string nome;
    
    public Animal():this("Sem nome", -1, -1, -1){}
    

    public Animal(string _nome, int _ano, decimal _altura, decimal _peso){
        ano=_ano;
        altura=_altura;
        peso = _peso;
        nome= _nome;
    }

    public virtual void EmiteSom(){
        Console.WriteLine("O som do animal");
    }

    public virtual string toString(){
        return "nome "+nome+ "\nano "+ano+"\naltura "+altura+"\npeso "+peso;
    }


}