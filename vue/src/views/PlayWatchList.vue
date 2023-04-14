<template>
  <div class="playlist">
    <div class="watchlist">
      <h1>Welcome!</h1>
      <h2>Here you can create a watchlist or a playlist.</h2>
      <div class="setPlaylist">
        <p>What would you like to call your playlist?</p>
        
      </div><input
          v-model="inputPlaylistName"
          type="text"
          placeholder="Playlist Name"
        />
      <div class="addWatchList">
        <p>Add to Watch List</p>
        </div><input
          v-model="inputWatchList"
          type="text"
          placeholder="Select a Title"
        />
    </div>
  </div>
</template>

<script>

export default {
  name: "playwatchlist",
  components: {  },
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
  align-items: center;  
}
input {
  width: 25%;
}

</style>