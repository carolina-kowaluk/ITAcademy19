public class Gato: Animal
{
    private string raca;
    public Gato(string _raca){
        raca = _raca;
    }
    public override void EmiteSom(){
        Console.WriteLine("Ronronar");
    }
    public override string toString(){

        return base.toString()+"\nA raça do gato é: "+raca;
    }   
}