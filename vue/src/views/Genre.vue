<template>

  <div class="genre">
    <h1 id="genrename" class="text-center">{{genrename}}</h1>
    <movies-display-store/>
    <!-- <jumpscare/> -->
    <!-- <jumpscare-two/> -->
    </div> 
</template>

<script>
import MoviesDisplayStore from '../components/MoviesDisplayStore.vue'
import MoviesService from '../services/MoviesService'
// import Jumpscare from '../components/Jumpscare.vue'
// import JumpscareTwo from '../components/JumpscareTwo.vue'

export default {
    name: "genre",
    data() {
        return {
            // moviesByGenre: [],
            genreId: this.$store.state.currentGenreId,
            genrename: ''
        }
    },
     created() {   
       //console.log(this.$route.params.id)
       this.genrename = this.$route.params.name; 
        MoviesService.getMovieByGenre(this.$route.params.id).then((response) => {
        
        // this.moviesByGenre = response.data.results;
        this.$store.commit('UPDATE_MOVIES', response.data.results)

        
        });
    },
  components: { MoviesDisplayStore },
}
</script>

<style>
.genre {
  padding-bottom: 12vh;
}
#genrename {
  padding-top:30px;
  display: flex;
  justify-content: center;
  font-size: 50px;
  color: black;
  -webkit-text-stroke-width: 1px;
  -webkit-text-stroke-color: black;
}


</style>