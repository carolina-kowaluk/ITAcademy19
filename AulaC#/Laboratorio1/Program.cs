// See https://aka.ms/new-console-template for more information
byte b;
b = byte.MaxValue;
Console.WriteLine("Valor maximo de byte: " + b); 
//Console.WriteLine($"Valor maximo de byte: {b}"); //interpolação de strings

//int i;
//i = int.MaxValue;
//Console.WriteLine("Valor maximo de int: " + i);

long l;
l = long.MaxValue;
Console.WriteLine("Valor maximo de long: " + l);

// string strPrimeira = "Alo "; 
// string strSegunda = "Mundo"; 
// string strTerceira = strPrimeira + strSegunda;
// Console.WriteLine(strTerceira); 
// int cchTamanho = strTerceira.Length;
// string strQuarta = "Tamanho = " + cchTamanho.ToString(); 
// Console.WriteLine(strQuarta);
// Console.WriteLine(strTerceira.Substring(0, 5));

DateTime dt = new DateTime(2015, 04, 23);
string strQuinta = dt.ToString();
Console.WriteLine(strQuinta); 

int i = 10; 
float f = 0; 
f = i; //conversão implícita, sem perda de dados. 
System.Console.WriteLine(f); 
f = 0.5F; 
i = (int) f; //conversão explícita, com perda de dados. 
System.Console.WriteLine(i);

// string stringInteiro = "123456789"; 
// int valorStringInteiro = Convert.ToInt32(stringInteiro); 
// Console.WriteLine(valorStringInteiro); 
// Int64 valorInt64 = 123456789; 
// int valorInt = Convert.ToInt32(valorInt64); 
// Console.WriteLine(valorInt);

//erro
// string stringInteiroGrande = "999999999999999999999999999999999999999999999"; 
// int valorStringInteiroGrande = Convert.ToInt32(stringInteiroGrande);

string stringInteiro = "123456789"; 
int valorStringInteiro; 
bool conversao1 = Int32.TryParse(stringInteiro, out valorStringInteiro); 
Console.WriteLine("Conversão efetuada:" + conversao1 + " Valor: " + valorStringInteiro); 
 
 
string stringInteiroGrande = "999999999999999999999999999999999999999999999"; 
int valorStringInteiroGrande; 
bool conversao2 = Int32.TryParse(stringInteiroGrande, out valorStringInteiroGrande); 
Console.WriteLine("Conversão efetuada:" + conversao2 + " Valor: " + valorStringInteiroGrande); 
 
string stringLetras = "abc"; 
double valorStringLetras; 
bool conversao3 = Double.TryParse(stringLetras, out valorStringLetras);

Console.WriteLine("Conversão efetuada:" + conversao3 + " Valor: " + valorStringLetras);

double valorFracionado = 4.7; 
int valorInteiro1 = (int) valorFracionado; 
int valorInteiro2 = Convert.ToInt32(valorFracionado); 
Console.WriteLine("Conversao explicita = " + valorInteiro1); 
Console.WriteLine("Conversao metodo Convert = " + valorInteiro2);

int x = 10; 
double y = 3.4; 
Console.WriteLine("{0}  {1}",x,y); 
Console.WriteLine($"{x} {y}");