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
.grid-container {
  display: grid;
  grid-template-columns: 1fr;
  gap: 10px;
  font-size: 100%;
  font-family: fantasy;
  border: 5px solid white;
}
.movie-list {
  border: 5px solid yellow;
  /* need to find a way to loop through all the movies and display them as seperate elements so they can be manipulated */
}
</style>
