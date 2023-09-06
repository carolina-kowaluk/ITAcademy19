import { types } from "util";

//Inicializador de objetos
const pessoa = {
    nome: 'John Doe',
    idade: 22
};
console.log(pessoa.nome);
console.log(pessoa.idade);
pessoa.idade = 23;
console.log(pessoa.idade);
console.log(typeof pessoa);

const outraPessoa = {
    nome: 'Mary Doe',
    idade: 25,
    saudar: function() { //função
        return `Olá! Meu nome é ${this.nome}`;
    }
};
console.log(outraPessoa.idade);
console.log(outraPessoa.saudar());


const maisUmaPessoa = {
    nome: 'Carolina',
    idade: 25,
    saudar () { //método
        return `Olá! Meu nome é ${this.nome}`;
    }
}
console.log(maisUmaPessoa.saudar());

type Pessoa = {nome:string; idade:number}
function alo(umaPessoa:Pessoa) { //um objeto que tem pelo menos nome e idade
    console.log(`Alô, ${umaPessoa.nome}! Você tem ${umaPessoa.idade} anos!`);
}
alo(pessoa);
alo(outraPessoa);
alo(maisUmaPessoa);

const temperatura = {
    celcius: 23,
    get fahrenheit() { //get é propriedade de leitura
        return this.celcius * 1.8 + 32;
    }
};
console.log(temperatura.celcius);
console.log(temperatura.fahrenheit);

const outraTemperatura = Object.create(temperatura);
outraTemperatura.celcius = 13;
console.log(outraTemperatura.celcius);
console.log(outraTemperatura.fahrenheit);


//Função construtora de objetos
// type Carro = {modelo:string, fabricante:string, ano:number};
// function Carro(this:Carro, modelo:string, fabricante:string, ano:number) {
//     this.modelo = modelo;
//     this.fabricante = fabricante;
//     this.ano = ano;
// }
// const carro = new (Carro as any) ('Fusca', 'VW', 1970);
// console.log(carro);