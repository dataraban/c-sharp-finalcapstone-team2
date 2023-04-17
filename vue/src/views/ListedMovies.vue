<template>
  <div id="movieList">
    <movies-display v-bind:movies="movies" />
  </div>
</template>
<script>
import MoviesService from "../services/MoviesService.js";
import MoviesDisplay from "../components/MoviesDisplay.vue";
export default {
  name: "listed",
  props: {
    listId: {
      type: Number,
      required: true,
    },
  },
  data() {
    return {
      movies: [],
    };
  },
  methods: {
    getMovieFromList(movie) {
      MoviesService.getMovieById(movie.movie_id).then((response) => {
        const movieSelected = response.data;
        this.movies.push(movieSelected);
      });
    },
  },
  created() {
    const movieList = dataFetchingPlaceHolder(this.listId);
    movieList.forEach((movie) => {
      this.getMovieFromList(movie);
    });
  },
  components: { MoviesDisplay },
};
</script>
<style scoped>
</style>