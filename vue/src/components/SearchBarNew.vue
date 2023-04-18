<template>
  <div id="searchBar">
    <div class="input-group">
      <div class="form-outline">
        <input
          id="search-input"
          type="search"
          class="form-control"
          placeholder="Type Here to Search"
          v-model="searchInput"
        />
        <!-- <label class="form-label" for="search-input">Search</label> -->
      </div>
      <button
        id="search-button"
        type="button"
        class="btn btn-primary"
        v-on:click="doSearch"
      >
        Go
      </button>
    </div>
  </div>
</template>

<script>
import MoviesService from "../services/MoviesService";

export default {
  data() {
    return {
      searchInput: "",
      movies: [],
    };
  },
  methods: {
    doSearch() {
      MoviesService.getMovieByMulti(this.searchInput).then((response) => {
        this.movies = response.data.results;
      });
      this.$router.push(`/search/${this.searchInput}`);
      this.searchInput = "";
      this.$router.go();
    },
  },
};
</script>

<style>
.input-group {
  margin-left: 2vh;
}

#searchBar {
  display: inline;
  align-self: center;
  color: rgb(50, 20, 185);

}
</style>