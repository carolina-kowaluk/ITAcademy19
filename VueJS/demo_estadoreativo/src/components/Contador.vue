<script setup lang="ts">
import {ref} from 'vue'; 
const contagem = ref(0);

function incrementaContagem() {
    contagem.value++;
}

function tratadorDoClick() {
    incrementaContagem();
}

</script>

<template>
    <div>
        <button>Clique aqui</button>
        <span>foi clicado {{  }} vezes</span>
    </div>
</template>