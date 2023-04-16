<template>
  <div>
    <li v-for="movie in movies" :key="movie.id">
      <router-link
        v-bind:to="{ name: 'movie-details', params: { id: movie.id } }"
      >
        <img
          v-bind:src="'https://image.tmdb.org/t/p/w185' + movie.poster_path"
        />
      </router-link>

      <p>{{ movie.original_title }}</p>
    </li>
  </div>
</template>

<script>
export default {
  name: "movies-display",
  props: {
    movies: [],
  },
};
</script>

<style scoped>

div {
  display: flex;
  flex-wrap: wrap;
  padding-top: 2vh;
  justify-content: center;
}
li{
text-align: start;}

p{
overflow-wrap: break-word;}
</style>