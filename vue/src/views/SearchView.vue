<template>
  <div>
    <movies-display-store/>

    </div> 
</template>

<script>
import MoviesDisplayStore from '../components/MoviesDisplayStore.vue'
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
          this.moviesBySearch = this.moviesBySearch.filter((movie) => {
            return movie.title !== undefined
          })
          this.$store.commit('UPDATE_MOVIES', this.moviesBySearch)

                  
        // this.movieIds = response.data.results;
        
        // this.movieIds.id.forEach((movieId) => {
        //   MoviesService.getMovieById(movieId).then((response) => {
        //     this.moviesBySearch.push(response.data.results);
        //   })
        // })
        
        });
        // console.log(this.$route.params.keyword);
    },
  components: { MoviesDisplayStore },
}
</script>

<style>


</style>