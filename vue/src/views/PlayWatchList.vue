<template>
  <div class="playlist">
    <nav-bar class="nav"></nav-bar>
    <div class="watchlist">
      <h1>Welcome!</h1>
      <h2>Here you can create a watchlist or a playlist.</h2>
      <div class="setPlaylist">
        <p>What would you like to call your playlist?</p>
        <input
          v-model="inputPlaylistName"
          type="text"
          placeholder="Playlist Name"
        />
      </div>
    </div>
  </div>
</template>

<script>
import NavBar from "../components/NavBar.vue";

export default {
  name: "playwatchlist",
  components: { NavBar },
  data() {
    return {
      inputPlaylistName: "",
    };
  },
};
</script>

<style>
.watchlist {
  display: flex;
  flex-direction: column;
  height: 100vh;
  width: 100vw;
  justify-content: center;
  align-items: center;  
}

</style>