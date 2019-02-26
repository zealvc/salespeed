<template>
  <span>
    <v-toolbar
      height="70px"
      flat
      app
      dark
      color="#000000AA"
      scroll-off-screen
      scroll-threshold="1"
      align-center
      justify-start
    >
      <v-toolbar-items class="hidden-sm-and-down">
        <img src="kit-1.png" style="height: inherit; width: auto" class="pa-2">
        <toolbar-item-button v-for="item in items" :key="item.title">
          {{ item.title }}
        </toolbar-item-button>
      </v-toolbar-items>
      <v-spacer />
      <v-btn flat>
        <v-icon>search</v-icon>
      </v-btn>
    </v-toolbar>
  </span>
</template>

<script>
import ToolbarItemButton from './ToolbarItemButton'
export default {
  name: 'AppNavigation',
  components: { ToolbarItemButton },
  data() {
    return {
      drawer: false,
      items: [
        { icon: 'apps', title: 'Home', to: '/inspire' },
        { icon: 'bubble_chart', title: 'Event', to: '/inspire' },
        { icon: 'bubble_chart', title: 'Internship', to: '/inspire' },
        { icon: 'bubble_chart', title: 'Scholarship', to: '/inspire' },
        { icon: 'bubble_chart', title: 'Student Life', to: '/inspire' }
      ]
    }
  }
}
</script>

<style scoped>
</style>
