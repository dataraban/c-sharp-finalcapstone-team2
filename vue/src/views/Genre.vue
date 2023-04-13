<template>
  <div>
    <movies-display v-bind:movies="moviesByGenre"/>

    </div> 
</template>

<script>
import MoviesDisplay from '../components/MoviesDisplay.vue'
import MoviesService from '../services/MoviesService'

export default {
    name: "genre",
    data() {
        return {
            moviesByGenre: []
        }
    },
     created() {   
       console.log(this.$route.params.id) 
        MoviesService.getMovieByGenre(this.$route.params.id).then((response) => {
        
        this.moviesByGenre = response.data.results;
        
        });
    },
  components: { MoviesDisplay },
}
</script>

<style>

</style>