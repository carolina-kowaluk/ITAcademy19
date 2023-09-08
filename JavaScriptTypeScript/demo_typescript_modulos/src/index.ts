//importações sincronas
//importar os módulos
//com chaves{} seleciona oq importar
import {area, circunferencia as cir} from './circulo_funcoes';
//sem chaves importa o default
import Circ from './circulo_objeto';
import * as fs from 'node:fs';

//usando as funções 
console.log(area(3.75));
console.log(cir(3));

//usando classe importada
const c1 = new Circ(10.5);
console.log(c1.area());
console.log(c1.circunferencia());

//gravando um arquivo de texto em json
// const json = JSON.stringify(c1);
// try {
//     fs.writeFileSync('dados.json', json);
// } catch (error) {
//     console.error('Falha de escrever no arquivo');
//     console.error((error as Error).message);
// 

//leitura do arquivo texto
try {
    const json = fs.readFileSync('dados.json', {encoding:'utf-8'});
    const circulo:Circ = JSON.parse(json);
    console.log(circulo);
} catch (error) {
    console.error('Falha de escrever no arquivo');
    console.error((error as Error).message);
}
