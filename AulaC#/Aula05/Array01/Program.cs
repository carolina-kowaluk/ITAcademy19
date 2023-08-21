int [] vetor = new int[10];

Random r = new Random();

for(int i=0; i<vetor.Length; i++){
    vetor[i] = r.Next(101);
}

for(int i=0; i<vetor.Length; i++){
    Console.WriteLine(i+": "+vetor[i]);
}

Console.WriteLine("\\==============\\");
foreach(int valor in vetor){
    Console.WriteLine($"fe => {valor}");
}


