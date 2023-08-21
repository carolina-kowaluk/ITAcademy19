public class CirculoColorido : Circulo
{
    private Cor minhaCor; //atributo

    private Cor Cor //propriedade
    {
        get{return minhaCor;}
        set{minhaCor = value;}
    }

    public CirculoColorido()
    {
        minhaCor = Cor.Preto;
    }

    public CirculoColorido(double x, double y, double r, Cor c)
        : base(x, y, r)
    {
        minhaCor = c;
    }

    public override string ToString()
    {
        return base.ToString() + " cor=" + Cor;
    }

}