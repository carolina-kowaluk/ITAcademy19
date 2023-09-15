<script setup lang="ts">
import BotaoColorido from "./components/BotaoColorido.vue";
import LayoutBasico from "./components/LayoutBasico.vue";
</script>

<template>
  <LayoutBasico>
    <template #cabecalho>
      <h1>Exemplos de Slots</h1>
    </template>
    <template #default>
      <button type="button">Clique</button>
      <BotaoColorido>Clique Aqui</BotaoColorido>
      <BotaoColorido>
        <span>Curtir</span>🤍
      </BotaoColorido>
    </template>
    <template #rodape>
      <p>Desenvolvimento</p>
    </template>
  
  </LayoutBasico>
  
</template>

<style scoped>

</style>
