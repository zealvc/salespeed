<template>
  <span>
    <home-hero/>
    <home-details/>
  </span>
</template>

<script>
import HomeDetails from '../components/HomeDetails'
import HomeHero from '../components/HomeHero'
export default {
  components: {
    HomeDetails,
    HomeHero
  }
}
</script>
