<template>
    <button type="button" class="botao-colorido">
        <slot>Botão</slot>
        
    </button>


</template>


<style scoped>
    .botao-colorido {
        color:white;
        background: linear-gradient(315deg, #854997 25%, #5250b4);
        border: none;
        padding: 5px 10px;
        margin: 5px;
        border-radius: 8px;
        cursor: pointer;
    }

    .botao-colorido:hover {
        background: linear-gradient(315deg, #4c2956, #353475); /* Cor que deseja quando o cursor passar por cima */
    } 

</style>