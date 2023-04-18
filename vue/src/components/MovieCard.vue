<template>
  <div class="card">
    <h2 class="movie-title">{{ movie.title }}</h2>
    <!--Get movie image -->
    <router-link
      v-bind:to="{ name: 'movie-details', params: { id: movie.id } }"
    >
      {{ movie.title }}
    </router-link>
  </div>
</template>

<script>
export default {
  name: "movie-card",
  props: {
    movie: Object,
  },
  methods: {},
};
</script>

<style>
.card {
  border: 2px solid black;
  border-radius: 10px;
  width: 250px;
  height: 550px;
  margin: 20px;
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
}
.card .movie-title {
  font-size: 1.5rem;
  font-family: fantasy;
}
.card .movie-details {
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  align-content: center;
  font-family: Verdana, Geneva, Tahoma, sans-serif;
}
</style>