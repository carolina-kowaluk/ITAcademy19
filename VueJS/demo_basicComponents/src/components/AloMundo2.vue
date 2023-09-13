<script setup lang="ts">
const nome = 'Carolina Kowaluk';
</script>

<template>
  <h2>Alô, {{ nome }}!</h2>
  <p>
    São <time :datetime ="Date()">{{ new Date().toLocaleTimeString() }}</time> horas.
  </p>
</template>