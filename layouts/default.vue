<template>
  <v-app dark>
    <app-navigation />

    <v-content>
      <nuxt />
    </v-content>

    <app-footer />
  </v-app>
</template>

<script>
import AppNavigation from '../components/AppNavigation'
export default {
  components: { AppNavigation },
  data() {
    return {
      clipped: false,
      drawer: false,
      fixed: false,
      items: [
        {
          icon: 'apps',
          title: 'Welcome',
          to: '/'
        },
        {
          icon: 'bubble_chart',
          title: 'Inspire',
          to: '/inspire'
        }
      ],
      miniVariant: false,
      right: true,
      rightDrawer: false,
      title: 'Vuetify.js'
    }
  }
}
</script>
