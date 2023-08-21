namespace Lab5;
class Program
{
    static void Main(string[] args)
    {
        Circulo circ1 = new Circulo();
        //Console.WriteLine(circ1);
        Circulo circ2 = new Circulo(2.4, 5, 3);
        //Console.WriteLine(circ2);
        CirculoColorido circ3 = new CirculoColorido();
        //Console.WriteLine(circ3);
        CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, Cor.Vermelho);
        //Console.WriteLine(circ4);
        //Console.WriteLine(circ4.CentroX); //sim é possivel usar propriedades do CentroX para o CirculoColorido 
        CirculoColoridoPreenchido circ5 = new CirculoColoridoPreenchido();
        //Console.WriteLine(circ5);
        CirculoColoridoPreenchido circ6 = new CirculoColoridoPreenchido(2.5, 2.9, 2, Cor.Preto, Cor.Azul);
        //Console.WriteLine(circ6);

        Circulo [] circulos = new Circulo[6];
        circulos[0] = circ1;
        circulos[1] = circ2;
        circulos[2] = circ3;
        circulos[3] = circ4;
        circulos[4] = circ5;
        circulos[5] = circ6;

        for(int i=0; i<circulos.Length; i++){
            Console.WriteLine(circulos[i]);
        }
    }
}
