<template>
  <div class="playlist">
    <div class="watchlist">
      <h2>Here you can view or create your playlist and add to your watch list.</h2>
      <div class="setPlaylist">
        <p>What would you like to call your playlist?</p>
        
      </div><input
          v-model="newPlaylist" type="text" placeholder="Playlist Name" />
      <br>
      <div class="addWatchList">
        <p>Add to Watch List</p>
        </div><input
          v-model="newWatchList" type="text" placeholder="Select a Title"/>
    </div>
  </div>
</template>

<script>
export default {
  name: "playwatchlist",
  components: {},
  data() {
    return {
      newPlaylist: '',
      newWatchList: ''
    };
  },
   methods: {
    addNewPlaylist() {
      this.$store.commit('ADD_PLAYLIST', this.newPlaylist);
    },
    addNewWatch() {
      this.$store.commit('ADD_WATCHLIST', this.newPlaylist);
    }
   }
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