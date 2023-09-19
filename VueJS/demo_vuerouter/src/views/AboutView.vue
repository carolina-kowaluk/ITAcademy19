<script setup lang="ts">
import { useRoute } from 'vue-router';
const route = useRoute();
const parametro = route.params.nome;
</script>

<template>
  <div class="about">
    <h1>About page</h1>
    <p>{{ parametro }}</p>
  </div>
</template>
