<template>
  <div class="home">
    <div class="grid-container">
      <movies-display v-bind:movies="this.movies"/>
    </div>
    <div class="carousel">
      <!-- saving space to build in carousel functionality here -->
    </div>
  </div>
</template>
<script>
import MoviesDisplay from '../components/MoviesDisplay.vue'
import MoviesService from '../services/MoviesService'

export default {
  name: "home",
  data() {
    return {
      movies: [],
    };
  },
  methods: {
    getMovieById(id) {
      this.$router.push(`/movie/${id}`);
      //console.log(id);
    },
  },
  created() {
    MoviesService.listMovies().then((response) => {
      this.movies = response.data.results;
    });
  },
  components: { MoviesDisplay }
};
</script>

<style scoped>
.grid-container{
  list-style: none;
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  padding-top: 2vh;
  padding-inline: 5vw;
}

</style>
