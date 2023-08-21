IPilha p = new Pilha();

Console.WriteLine(p);

p.Empilha("x1");
p.Empilha("x2");
p.Empilha("x3");
p.Empilha("x4");
p.Empilha("x5");

Console.WriteLine($"A pilha tem {(p as Pilha).qtdElementos()} elementos");
Console.WriteLine($"O elemento {p.Topo} está no topo");
p.Desempilha();

Console.WriteLine($"A pilha tem {(p as Pilha).qtdElementos()} elementos");
Console.WriteLine($"O elemento {p.Topo} está no topo");
p.Desempilha();

Console.WriteLine($"A pilha tem {(p as Pilha).qtdElementos()} elementos");
Console.WriteLine($"O elemento {p.Topo} está no topo");
p.Desempilha();

Console.WriteLine($"A pilha tem {(p as Pilha).qtdElementos()} elementos");
Console.WriteLine($"O elemento {p.Topo} está no topo");
p.Desempilha();

IUmaCoisa iuc = new Pilha();
iuc.metodo();

IOutraCoisa ioc = new Pilha();
ioc.metodo();
