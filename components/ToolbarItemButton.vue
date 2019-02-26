<template>
  <v-btn
    flat
    class="subheading text-capitalize font-weight-bold white--text toolbar-item-text"
  >
    <slot />
  </v-btn>
</template>

<script>
export default {
  name: 'ToolbarItemButton'
}
</script>

<style scoped>
.toolbar-item-text {
  font-weight: normal;
}
</style>
