<template>
  <div>
    <movies-display v-bind:movies="moviesBySearch"/>

    </div> 
</template>

<script>
import MoviesDisplay from '../components/MoviesDisplay.vue'
import MoviesService from '../services/MoviesService'

export default {
    name: "search",
    data() {
        return {
            movieIds: [],
            moviesBySearch: [],
        }
    },
     created() {   
       //console.log(this.$route.params.id) 
        MoviesService.getMovieByMulti(this.$route.params.keyword).then((response) => {
          this.moviesBySearch = response.data.results;        
        // this.movieIds = response.data.results;
        
        // this.movieIds.id.forEach((movieId) => {
        //   MoviesService.getMovieById(movieId).then((response) => {
        //     this.moviesBySearch.push(response.data.results);
        //   })
        // })
        
        });
        console.log(this.$route.params.keyword);
    },
  components: { MoviesDisplay },
}
</script>

<style>


</style>