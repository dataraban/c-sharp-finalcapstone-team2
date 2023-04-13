<template>
  <div class="home">
    <div class="grid-container">
      <nav-bar class="nav"></nav-bar>
      <!-- <movie-card/> -->
      <movies-list class="movie-list" />
    </div>
    <div class="carousel">
      <!-- saving space to build in carousel functionality here -->
    </div>
  </div>
</template>

<script>
//import MovieCard from '../components/MovieCard.vue';
import MoviesList from "../components/MoviesList.vue";
import NavBar from "../components/NavBar.vue";
export default {
  components: {
    //MovieCard,
    MoviesList,
    NavBar,
  },
  name: "home",
};
</script>

<style scoped>

</style>
