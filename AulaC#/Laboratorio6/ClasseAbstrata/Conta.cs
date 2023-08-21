public abstract class Conta
{
    private decimal saldo;
    private string titular;

    public Conta(string t)
    {
        titular  = t;
    }

    public decimal Saldo
    {
        get{return saldo;}
    }

    public string Titular
    {
        get{return titular;}
    }

    // Propriedade abstrata de leitura que retorna um identificador da conta
    // Será implementada pelas classes derivadas
    public abstract string Id 
    {
        get;
    }

    public virtual void Depositar(decimal valor)
    {
        saldo += saldo;
    }

    public virtual void Sacar(decimal valor)
    {
        saldo -= valor;
    }

}