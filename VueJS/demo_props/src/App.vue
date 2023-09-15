<script setup lang="ts">
import AloMundo from './components/AloMundo.vue';
import AloMundo2 from './components/AloMundo2.vue';
import AloMundo3 from './components/AloMundo3.vue';
import AloMundo4 from './components/AloMundo4.vue';
import { Pessoa } from './Pessoa';
import { ref } from 'vue';

const vips = ref([
  new Pessoa(1, 'João', 23),
  new Pessoa(2, 'Rita', 19),
  new Pessoa(3, 'Maria', 20)
]);
</script>

<template>
    <!--
    <AloMundo nome="Carol"/>
    <AloMundo />
    <AloMundo2 nome='Carolina'/>
    <p>Repetição = 2</p>
    <AloMundo3 nome="Maria" :repeticao="2"/>
    <p>Sem repetição</p>
    <AloMundo3 nome="Maria"/>
    -->
    <AloMundo4 :pessoas="vips"/>
</template>

<style scoped>
</style>
