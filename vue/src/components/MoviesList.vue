<template>
  <div>
    <ul id="movieList">
      <li v-for="movie in movies" :key="movie.id">
        <!-- <router-link v-bind:to="{name: 'movie-details', params: {id: movie.id}}"> -->
        <img
          v-bind:src="'https://image.tmdb.org/t/p/w185' + movie.poster_path"
          v-on:click="getMovieById(movie.id)"
        />
        <!-- </router-link> -->
        <p id="title">{{ movie.original_title }}</p>
        <!-- <p id="release date">{{ movie.release_date }}</p> -->
        <!-- {{movie.poster_path}} gets literal path -->
      </li>
    </ul>
  </div>
</template>

<script>
import MoviesService from "../services/MoviesService";

export default {
  name: "movies-list",
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
};
</script>

<style>

ul{
  list-style: none;
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  padding-top: 2vh;}
li{
  padding-inline: 5vw;
}


</style>