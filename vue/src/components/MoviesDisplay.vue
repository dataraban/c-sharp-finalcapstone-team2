<template>
  <div>
    <li v-for="movie in movies" :key="movie.id">
      {{ movie.original_title }}
      <router-link v-bind:to="{name: 'movie-details', params: {id: movie.id}}">

      <img
        v-bind:src="'https://image.tmdb.org/t/p/w185' + movie.poster_path"
        
      />

      </router-link>

      <p>{{ movie.original_title }} | {{ movie.release_date }}</p>
    </li>
  </div>
</template>

<script>

export default {
  name: "movies-display",
  props: {
    movies: []
  }
};
</script>

<style scoped>
li {
  list-style: none;
}
div{
  list-style: none;
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  padding-top: 2vh;}
  
</style>