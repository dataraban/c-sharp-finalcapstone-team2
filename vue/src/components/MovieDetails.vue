<template>
  <div class="details">
    <h2>
      {{ movie.title }}
    </h2>
    <img v-bind:src="'https://image.tmdb.org/t/p/w185' + movie.poster_path" />
    <p>Overview: {{ movie.overview }}</p>
    <p>Release date: {{ movie.release_date }}</p>
    <p>Runtime: {{ movie.runtime }} mins</p>
    <p>Revenue: ${{ movie.revenue.toLocaleString("en-US") }}</p>
    <p v-if="movie.homepage">
      Homepage: <a :href="movie.homepage">{{ movie.homepage }}</a>
    </p>
    <h4>Genres</h4>
    <ul>
      <li v-for="genre in movie.genres" :key="genre.id">{{ genre.name }}</li>
    </ul>
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
  display: grid;
  height: 100%;
  width: 100%;
  align-items: center;
  justify-items: center;
  margin: auto;
  text-align: center;
  padding-right: 25%;
  padding-left: 25%;
}
</style>