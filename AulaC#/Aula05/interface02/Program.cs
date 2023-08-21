Pessoa p1 = new ("Carol", 19);
Pessoa p2 = new Pessoa("Carol", 19);
Pessoa p3 = p1;

Console.WriteLine(p1);
Console.WriteLine(p2);

Console.WriteLine(p1==p2);
Console.WriteLine(p1==p3);
Console.WriteLine(p3==p2);

Console.WriteLine(p1.Equals(p2));
Console.WriteLine(p1.Equals(p3));
Console.WriteLine(p3.Equals(p2));
