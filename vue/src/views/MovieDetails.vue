<template>
  <div>
    <nav-bar class="nav"></nav-bar>
    <movie-details />
  </div>
</template>

<script>
import MovieDetails from "../components/MovieDetails.vue";
import NavBar from "../components/NavBar.vue";

export default {
  components: { MovieDetails, NavBar },
};
</script>

<style>
</style>