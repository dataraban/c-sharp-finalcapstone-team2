<template>
  <div class="input-group">
  <div class="form-outline">
    <input id="search-input" type="search" class="form-control" placeholder="Search" v-model="searchInput" />
    <!-- <label class="form-label" for="search-input">Search</label> -->
  </div>
  <button id="search-button" type="button" class="btn btn-primary" v-on:click=doSearch>Click To Search
    <!-- <i class="fas fa-search" v-on:click="doSearch"></i> -->
  </button>
</div>
</template>

<script>
// import MoviesDisplay from '../components/MoviesDisplay.vue'
import MoviesService from '../services/MoviesService'

export default {
    data() {
        return{
        searchInput: '',
        movies: []
        }
    },
    methods: {
        doSearch(){
            MoviesService.getMovieByMulti(this.searchInput).then((response) => {        
                this.movies = response.data.results;      
            });
            this.$router.push(`/search/${this.searchInput}`);
            this.searchInput = '';
            this.$router.go();
        }
    },
    created() {   
       //console.log(this.$route.params.id) 

    },

    // components: { MoviesDisplay }
}
</script>

<style>
.input-group{
    margin-left: 2vh;
}

</style>