class Moeda {
    valor: number;
    nome: string;
    constructor(v:number, n:string){
        this.valor = v;
        this.nome = n;
    }
    get v() {
        return this.valor;
    }
    get n() {
        return this.nome;
    }
}

class Cofrinho {
    moedas: Moeda[] = [];
    constructor(moedas:Moeda[]){
        this.moedas = moedas;
    }
    adiciona(m:Moeda) {
        this.moedas.push(m);
    }
    calcularTotal() : number {
        let total = 0;
        for (let i = 0; i < this.moedas.length; i++) {
            total = total + this.moedas[i].valor;
        }
        return total;
    }
}

// Criar algumas moedas e um cofrinho
const moeda1 = new Moeda(0.25, "quarto de dólar");
const moeda2 = new Moeda(0.1, "dime");
const moeda3 = new Moeda(0.05, "nickel");
const meuCofrinho = new Cofrinho([moeda1, moeda2, moeda3]);

// Serializar o objeto Cofrinho em JSON
const cofrinhoJSON = JSON.stringify(meuCofrinho);

// Exibir o JSON serializado
console.log(cofrinhoJSON);