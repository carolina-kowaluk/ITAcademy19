<script setup lang="ts">
  function tratadorDoClick(_evento: Event) {
    alert('Alô, mundo!');
  }
  function tratadorDoClick2(evento: Event) {
    const botaoClicado = evento.currentTarget as HTMLButtonElement;
    alert(`Alô, ${botaoClicado.name}!`);
  }
</script>

<template>
  <button type="button" @click="tratadorDoClick">Diga Alô</button>
  <button type="button" name="botaoOi" @click="tratadorDoClick2">Diga Oi</button>
</template>