<template>
  <div class="watchlist">
    <button
      id="show-form-button"
      v-if="showForm === false"
      v-on:click.prevent="showForm = true"
    >
      Click here to create your playlist and add to your watch list.
    </button>
    <form v-on:submit.prevent="addNewPlaylist" v-if="showForm === true">
      <div class="form-element">
        <label for="playlist">What would you like to call your playlist?</label>
        <input
          id="playlist"
          v-model="newPlaylist"
          type="text"
          placeholder="Playlist Name"
        />
      </div>
      <div class="form-element">
        <label for="watchlist">Add to Watch List</label>
        <input
          id="watchlist"
          v-model="newWatchList"
          type="text"
          placeholder="Select a Title"
        />
      </div>
      <input type="submit" value="Save" />
      <input type="button" value="Cancel" v-on:click="resetForm" />
    </form>
    <div class="current">
      <h3>Playlist</h3>
      <h3>Watch List</h3>
    </div>
  </div>
</template>

<script>
export default {
  name: "playwatchlist",
  components: {},
  data() {
    return {
      showForm: false,
      newPlaylist: "",
      newWatchList: "",
    };
  },
  resetForm() {
    this.showForm = false;
    this.newReview = {
      favorited: false,
    };
  },
  //  methods: {
  //   addNewPlaylist() {
  //     this.$store.commit('ADD_PLAYLIST', this.newPlaylist);
  //   },
  //   addNewWatch() {
  //     this.$store.commit('ADD_WATCHLIST', this.newPlaylist);
  //   }
  // }
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
div.form-element {
  margin-top: 10px;
}
div.form-element > label {
  display: block;
}
div.form-element > input,
div.form-element > select {
  height: 30px;
  width: 300px;
}
</style>