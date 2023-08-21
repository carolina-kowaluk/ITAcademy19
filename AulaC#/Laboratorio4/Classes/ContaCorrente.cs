using System;
class ContaCorrente
{
    private decimal saldo;
    private DateTime dataCriacao; 
    private string nomeTitular;
    public int count = 0;
    public decimal somaSaldo = 0;
    public decimal Saldo
    {
        get{return saldo;}
    }
    public DateTime Data
    {
        get{return dataCriacao;}
    }
    public string nome
    {
        get{return nomeTitular;}
    }
    public ContaCorrente(string nome)
    {
        nomeTitular = nome;
        dataCriacao = DateTime.Now;
    }

    public void Depositar(decimal val)
    {
        saldo = saldo + val;
        somaSaldo = somaSaldo + saldo;
        count++;
    }

    public void Sacar(decimal val)
    {
        saldo = saldo - val;
        somaSaldo = somaSaldo + saldo;
        count++;
    }
    public decimal MediaSaldo()
    {
        decimal mediaSaldo = 0;
        mediaSaldo = somaSaldo / count;
        return mediaSaldo;
    }

}