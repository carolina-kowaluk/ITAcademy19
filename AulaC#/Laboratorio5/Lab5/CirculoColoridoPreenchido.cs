public class CirculoColoridoPreenchido : CirculoColorido
{
    private Cor corAdicional;

    private Cor CorAdicional 
    {
        get{return corAdicional;}
        set{corAdicional = value;}
    }

    public CirculoColoridoPreenchido()
    {
        corAdicional = Cor.Preto;
    }

    public CirculoColoridoPreenchido(double x, double y, double r, Cor c, Cor a)
        : base(x,y,r,c)
    {
        CorAdicional = a;
    }

    public override string ToString()
    {
        return base.ToString() + " cor adicional=" + CorAdicional;
    }

}