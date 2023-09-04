let saudacao: string = 'Alô, mundo!';
console.log(saudacao);

//---------------------------------------------------------------//
function saudar() {
    console.log('Alô, mundo!');
}
saudar();

//---------------------------------------------------------------//
function saudarComNome(nome: string) {
    console.log(`Alô, ${nome}`);
}
saudarComNome('Carolina');

//---------------------------------------------------------------//
function criarSaudacao(nome : string) {
    return `Alô, ${nome}`;
}
console.log(criarSaudacao('Carolina'));

//---------------------------------------------------------------//
//expoente é opcional pois foi definido como 0
function potencia(base: number, expoente: number = 0) {
    let resultado = 1;
    for (let cont = 0; cont < expoente; cont++) {
        resultado = resultado * base;
    }
    return resultado;
}
console.log(potencia(2,3));
console.log(potencia(2));

//---------------------------------------------------------------//
//função anonima parecida com a arrow
const saudarAnonima = function(nome: string) {
    return `Alô, ${nome}`;
}
console.log(saudarAnonima);
console.log(saudarAnonima('Carolina'));

//---------------------------------------------------------------//
//função arrow: mais usada
const saudarArrow = (nome: string) => `Alô, ${nome}`;
console.log(saudarArrow('Carolina'));

//---------------------------------------------------------------//
//execução imediata de uma função: declara e já chama a função com os argumentos
(function (x: number, y: number) {
    console.log(x + y);
})(1,2);

//---------------------------------------------------------------//
//closure: função retorna outra função
function multiplicar(fator: number): (n: number) => number {
    return numero => numero * fator; //função anônima -> utiliza variavel fator da outra função
}

const dobrar = multiplicar(2); //numero => numero *2
console.log(dobrar(5)); //retorna 10
