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

//Construtor de objetos
type Carro = {modelo:string, fabricante:string, ano:number};
function Carro(this:Carro, modelo:string, fabricante:string, ano:number) {
    this.modelo = modelo;
    this.fabricante = fabricante;
    this.ano = ano;
}
const carro = new (Carro as any) ('Fusca', 'VW', 1970);
console.log(carro);