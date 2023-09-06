//As classes são do tipo Object
//classe com propriedades publicas
class Pessoa {
    nome: string;
    idade: number;
    constructor(nome:string, idade:number){
        this.nome = nome;
        this.idade = idade;
    }
}
const p1 = new Pessoa('Jonas', 22);
const p2 = new Pessoa('Maria', 25);
console.log(typeof p1);
console.log(p1);
console.log(p1.nome);


//Classe com propriedades publicas
class PessoaV2 {
    constructor(public nome:string, public idade:number){}
}
const p3 = new PessoaV2('Teste', 15);
console.log(p3);

//Classe com propriedades privadas
class PessoaV3 {
    #nome: string;
    #idade: number;
    #peso = 0;

    constructor(nome: string, idade: number) {
        this.#nome = nome;
        this.#idade = idade;
    }
    //propriedades de leitura e escrita
    get nome() {
        return this.#nome;
    }
    get idade() {
        return this.#idade;
    }
    get peso(){
        return this.#peso;
    }
    set peso(novoPeso: number){
        this.#peso = novoPeso;
    }
    fazAniversario() {
        this.#idade = this.#idade + 1;
    }
}
const p4 = new PessoaV3('Carol', 20);
console.log(p4);
console.log(p4.nome);
console.log(p4.idade);
p4.peso = 55.68;
console.log(p4.peso);
p4.fazAniversario();
console.log(p4.idade);

//desestruturação de um objeto
let {nome, idade} = p4;
console.log(nome);

function saudar ({nome}: Pessoa){
    console.log(`Alô, ${nome}!`);
}

saudar(p4);

//gerar JSON
const json = JSON.stringify(p1);
console.log(json); //mostra somente campos publicos
//ler JSON
const json2 = '{"nome":"Json da Silva", "idade":8}';
const obj2: Pessoa = JSON.parse(json2);
console.log(obj2);