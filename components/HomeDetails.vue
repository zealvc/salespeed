<template>
  <v-container
    fluid
  >
    <v-container
      class="blue-grey--text text--darken-3"
    />
    <FeaturesCard/>
  </v-container>
</template>

<script>
import FeaturesCard from './AppCards/FeaturesCard'
export default {
  name: 'HomeDetails',
  components: {
    FeaturesCard
  }
}
</script>

<style scoped>
</style>
