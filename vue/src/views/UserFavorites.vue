<template>
  <div>
    <movies-display v-bind:movies="favoriteMovies" />
  </div>
</template>

<script>
import MoviesDisplay from "../components/MoviesDisplay.vue";
import MoviesService from "../services/MoviesService";
import UserService from "../services/UserService";

export default {
  name: "favorites",
  data() {
    return {
      favoriteMovies: [],
      userMovies: [],
    };
  },
  created() {
    //console.log(this.$route.params.id)
    UserService.favoriteMovie(this.$store.state.user.userId).then((response) => {
      this.userMovies = response.data; 

      this.userMovies.forEach((movie) => {
      console.log(movie.movieId); 
      MoviesService.getMovieById(movie.movieId).then((response) => {
        this.favoriteMovies.push(response.data);
      });
    });
    });
    
  },
  components: { MoviesDisplay },
};
</script>

<style>
#genrename {
  padding-top: 30px;
  display: flex;
  justify-content: center;
  font-size: 50px;
  color: black;
  -webkit-text-stroke-width: 1px;
  -webkit-text-stroke-color: black;
}
</style> 

  