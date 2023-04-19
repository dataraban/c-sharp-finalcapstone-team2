<template>
  <div class="home">
    <div class="grid-container">
      <movies-display-store/>
    </div>
    <div class="carousel">
      <!-- saving space to build in carousel functionality here -->
    </div>
  </div>
</template>
<script>
import MoviesDisplayStore from '../components/MoviesDisplayStore.vue'
import MoviesService from '../services/MoviesService'

export default {
  name: "home",
  data() {
    return {
      // movies: [],
    };
  },
  methods: {
    getMovieById(id) {
      this.$router.push(`/movie/${id}`);
    },
  },
  created() {
    MoviesService.listMovies().then((response) => {      
      this.$store.commit('UPDATE_MOVIES', response.data.results)
    })
  },
  components: { MoviesDisplayStore }
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
