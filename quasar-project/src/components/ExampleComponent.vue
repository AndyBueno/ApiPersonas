<template>
  <q-page>
    <q-list>
      <q-item v-for="person in Personas" :key="person.id">
        <q-item-section>
          {{ person.name }}
        </q-item-section>
      </q-item>
    </q-list>
  </q-page>
</template>

<script>
import axios from 'axios';

export default {
  data() {
    return {
      personas: []
    }
  },
  mounted() {
    axios.get('https://localhost:7120/api/Persona')
      .then(response => {
        this.personas = response.data;
      })
      .catch(error => {
        console.error(error);
      });
  }
}
</script>