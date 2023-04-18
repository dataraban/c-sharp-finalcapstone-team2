<template>
  <div class="favorites">
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
.favorites {
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