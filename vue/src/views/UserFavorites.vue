<template>
  <div>
    <!-- <listed-movies/> -->
    Favorite Movies:
     <div v-for="movie in movies" v-bind:key="movie.id">{{ movie }}</div>
    </div> 
</template>

<script>
import UserService from "../services/UserService";
// import ListedMovies from "../components/ListedMovies.vue";
export default {
    name: "fav-movies",
  components: {},
  data() {
    return {
      movies: []
    };
  },
  created() {
    UserService.favoriteMovie(3).then((response) => {
      this.movies = response.data;
    });
  },
};


</script>

<style>

</style>