<template>
  <div>
    <v-container
      class="Feature"
    >
      <v-layout>
        <v-flex>
          <v-card
          color="#000000AA">
            <v-img
              src="https://cdn.vuetifyjs.com/images/cards/desert.jpg"
              aspect-ratio="3"
            ></v-img>

            <v-card-title primary-title>
              <div>
                <h3 class="headline mb-0">KIT Life</h3>
              </div>
            </v-card-title>
          </v-card>
        </v-flex>
      </v-layout>
    </v-container>
  </div>
</template>
<script>
export default {
  name: 'FeaturesCard'
}
</script>

<style scoped>
.Feature {
  margin-top: -250px;
}
</style>
