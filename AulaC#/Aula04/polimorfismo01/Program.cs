Pessoa p = new("Carol", 19);
Console.Write(p);

Funcionario f = new Funcionario(1500.13M);
Console.Write(f);

p.anoNascimento = 1990;
Console.Write(p);

f = new("Carol", 19, 1800);
Console.WriteLine(f);

Pessoa paux;
paux = p;
Console.WriteLine("//=======================");
Console.WriteLine("Pessoa");
Console.WriteLine(paux);
Console.WriteLine("Qual o seu humor?"+paux.humor());

paux = f;
Console.WriteLine("//=======================");
Console.WriteLine("Funcionario");
Console.WriteLine(paux);
Console.WriteLine("Qual o seu humor?"+paux.humor());
Console.WriteLine("é pessoa?"+(paux is Pessoa));
if(paux is Funcionario)
    Console.WriteLine("satisfeito com salario?"+(paux as Funcionario).satisfacaoSalario());


object oaux;
oaux=p;
Console.WriteLine("//=======================");
Console.WriteLine("oPessoa");
Console.WriteLine(oaux);
Console.WriteLine("Qual o seu humor?"+((Pessoa)oaux).humor());

oaux=f;
Console.WriteLine("//=======================");
Console.WriteLine("oFuncionario");
Console.WriteLine(oaux);
Console.WriteLine("Qual o seu humor?"+(oaux as Pessoa).humor());
Console.WriteLine("Qual o seu humor?"+(oaux as Funcionario).humor());


