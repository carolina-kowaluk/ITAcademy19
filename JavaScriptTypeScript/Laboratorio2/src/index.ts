const inicio = 5;
const fim = 10;
for (let i = inicio; i < fim+1; i++) {
    const numero = i;
    if(numero % 2 == 0){
        console.log(numero);
    }
}

//0.2 não é um múltiplo exato de 10, i nunca será igual a 10, e o loop é infinito
// let i: number = 0;
// while (i != 10) {
//  i += 0.2;
// }


function min(x: number, y: number) : number{
    if(x < y) {
        return x;
    }
    else{
        return y;
    }
}
console.log(min(1,3));
console.log(min(7,4));


function pow(x:number, y:number) : number{
    let resposta = 1;
    if(y==0){
        return resposta = 1;
    }
    else{
        for (let i = 1; i < y+1; i++) {
            resposta = resposta * x;
        }
        return resposta;
    }
}
console.log(pow(2,2));
console.log(pow(2,3));
console.log(pow(3,2));


function toMaiusculaPrimeira(s:string) : string{
    return s.charAt(0).toUpperCase() + s.slice(1);
}
console.log(toMaiusculaPrimeira("carolina Kowaluk"));

function getMax(arr: number[]) {
    let maior;
    for (let i = 0; i < arr.length-1; i++) {
        maior = arr[i];
        if(maior<arr[i+1]){
            maior = arr[i+1];
        }
    }
    return maior;
}
console.log(getMax([1,5,3,6,2]));


function calcularFrequenciaNumeros(array: number[]): Map<number, number> {
    const frequenciaMap = new Map<number, number>();
  
    for (const numero of array) {
      if (frequenciaMap.has(numero)) {
        // Se o número já existe no mapa, incrementa sua contagem
        frequenciaMap.set(numero, frequenciaMap.get(numero)! + 1);
      } else {
        // Se o número não existe no mapa, adiciona com contagem 1
        frequenciaMap.set(numero, 1);
      }
    }
  
    return frequenciaMap;
  }
  
  // Exemplo de uso:
  const numeros = [1, 2, 3, 1, 2, 4, 5, 3, 2, 1];
  const frequencia = calcularFrequenciaNumeros(numeros);
  console.log(frequencia);
  