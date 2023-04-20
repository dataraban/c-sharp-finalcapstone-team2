<template>
  <div class="details">
    <h2>
      {{ movie.title }}
    </h2>
    <img v-bind:src="'https://image.tmdb.org/t/p/w185' + movie.poster_path" />
    <p id="summary">Overview: {{ movie.overview }}</p>
    <div id="homepage">
      <p v-if="movie.homepage">
        Homepage: <a :href="movie.homepage">{{ movie.homepage }}</a>
      </p>
    </div>
    <div id="info">
      <p>Release date: {{ movie.release_date }}</p>
      <p>Runtime: {{ movie.runtime }} mins</p>
      <p>Revenue: ${{ movie.revenue.toLocaleString("en-US") }}</p>
    </div>
    <div id="genres">
      <h4>Genres</h4>
      <ul>
        <li v-for="genre in movie.genres" :key="genre.id">{{ genre.name }}</li >
      </ul>
    </div>
  </div>
</template>

<script>
import MoviesService from "../services/MoviesService";

export default {
  name: "movie-details",
  data() {
    return {
      movie: {
        id: null,
        name: "",
        title: "",
      },
    };
  },
  created() {
    MoviesService.getMovieById(this.$route.params.id).then((response) => {
      console.log(this.$route.params.id);
      this.movie = response.data;
    });
  },
  components: {},
};
</script>

<style>
.details {
  display: flex;
  flex-wrap: wrap;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  text-align: center;
}
#summary {
  width: 750px;
}
h2 {
  padding-top: 1%;
}
ul {
  text-align: center;
}
li {
  list-style: none;
  display: inline-block;
  text-align: left;
}
li:not(:last-child) { 
  margin: 5px;  
  justify-content: left;
}
</style>