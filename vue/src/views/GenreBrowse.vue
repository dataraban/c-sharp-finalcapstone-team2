<template>
<div>
        <nav-bar class="nav"></nav-bar>

  <div class="genrePage">
      <ul id="genreList">
      List of Genres
      <li v-for="genre in genres" :key="genre.id">
      {{ genre.name }}
      
      </li>
      </ul>
  </div>
  </div>
</template>

<script>
import MoviesService from "../services/MoviesService";
import NavBar from "../components/NavBar.vue";

export default {
    name: "genre-browse",
    data() {
        return {
            genres: []
        }
    },
    created() {    
        MoviesService.getAllGenres().then((response) => {
        this.genres = response.data.genres;
        });
    },
    components:{NavBar}

}
</script>

<style>
.genrePage{
    display: flex;
    flex-direction: column;
    height: 100vh;
    width: 100vw;
    text-align: center;
}
</style>