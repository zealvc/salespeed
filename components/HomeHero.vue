<template>
  <span>
    <v-container
      fluid
      fill-height
      class="home-hero hidden-sm-and-down pa-0"
      style="max-height: 100vh;"
    >
      <v-layout>
        <v-flex>
          <v-carousel hide-controls height="700px">
            <v-carousel-item
              v-for="(item,i) in items"
              :key="i"
              :src="item.src"
            ></v-carousel-item>
          </v-carousel>
          </v-flex>
      </v-layout>
    </v-container>
  </span>
</template>

<script>
export default {
  name: 'HomeHero',
  components: {},
  data() {
    return {
      items: [
        {
          src: 'https://kit.edu.kh/assets/images/slider/slider1.jpg'
        },
        {
          src: 'https://kit.edu.kh/assets/images/slider/slider3.jpg'
        },
        {
          src: 'https://kit.edu.kh/assets/images/slider/slider2.jpg'
        }
      ]
    }
  }
}
</script>

<style scoped>
.home-hero {
  background-size: cover;
  width: 100%;
  height: 100%;
  margin-top: -80px;
}
</style>
