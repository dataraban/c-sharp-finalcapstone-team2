<template>
  <div id="nav">
    <router-link class="home" v-bind:to="{ name: 'home' }">
      <button id="homeBtn">Home</button></router-link
    >

    <router-link
      class="logout"
      v-bind:to="{ name: 'logout' }"
      v-if="$store.state.token != ''"
      ><button id="logoutBtn">Logout</button></router-link
    >

    <router-link v-bind:to="{ name: 'playlist' }">
      <button id="watchListBtn">Watch List</button></router-link
    >

    <div class="genredropdown">
      <button id="genreBtn" href="#">Genres</button>

      <div class="dropdown-content">
        <router-link
          v-for="genre in genres"
          :key="genre.id"
          v-bind:to="{ name: 'genre-id', params: { id: genre.id } }"
          v-on:click.native="changeGenre(genre.id)"
        >
          {{ genre.name }}
        </router-link>
        <!-- <div
          v-for="genre in genres"
          :key="genre.id"
          v-bind:to="{ name: 'genre-id', params: { id: genre.id } }"
          v-on:click="changeGenre(genre.id)"
        >
          {{ genre.name }}
        </div> -->
      </div>
    </div>

    <search-bar class="search">Search:</search-bar>
    <input
      class="filter"
      type="text"
      v-model="filteredData"
      placeholder="Search Here"
    />
    <router-link v-bind:to="{ name: 'user-profile' }">
      <button id="userBtn">
        Welcome User

        <!-- want to be able to input the logged in users name in here-->
        <img
          class="user_icon"
          src="https://upload.wikimedia.org/wikipedia/commons/9/99/Sample_User_Icon.png"
        /></button
    ></router-link>
  </div>
</template>

<script>
import SearchBar from "./SearchBar.vue";
import MoviesService from "../services/MoviesService";
export default {
  components: { SearchBar },
  data() {
    return {
      genres: [],
    };
  },
  created() {
    MoviesService.getAllGenres().then((response) => {
      this.genres = response.data.genres;
    });
  },
  methods: {
    changeGenre(genreId) {
      //this.$store.commit('CHANGE_GENRE_ID', genreId);
      // this.$router.push({name: 'genre-id', params:{id: genreId}})
      this.$router.go();
      console.log(genreId);
    }
  }
};
</script>


<style scoped>
@import url('https://fonts.cdnfonts.com/css/dressed');
#nav {
  display: grid;
  width: 100%;
  height: 100%;
  grid-template-columns: repeat(6, 1fr);
  grid-template-rows: 2, 1fr;
  padding: 15px;
  background-image: url("https://static.vecteezy.com/system/resources/previews/008/630/206/original/groovy-pattern-groovy-background-camo-pattern-free-vector.jpg");
}
button {
  border-width: 1px;
  border-color: pink;
  border-top: none;
  border-bottom: none;
  display: flex;
  align-items: center;
  justify-content: center;
  color: rgb(113, 12, 133);
  font-size: large;
  font-family: 'Dressed', sans-serif;
  grid-row: 1;
  height: 100%;
  width: 100%;
  background-color: plum;
}
#homeBtn {
  grid-column: 1/2;
}
#logoutBtn {
  grid-column: 2/3;
}
#watchListBtn {
  grid-column: 3/4;
}
#genreBtn {
  grid-column: 4/5;
}
.genredropdown {
  float: left;
  overflow: hidden;
}
.dropdown-content {
  display: none;
  position: absolute;
  background-color: #f1f1f1;
  overflow: scroll;
  max-height: 35vh;
  width: 35vh;
}
.dropdown-content a {
  float: none;
  display: block;
  padding: 12px 16px;
  color: black;
}
.genredropdown:hover .dropdown-content {
  display: inline-block;
}
.genredropdown:hover a:hover {
  background: orange;
}

input {
  border: none;
  grid-row: 1;
  grid-column: 5/6;
  display: flex;
  text-align: center;
  color: rgb(50, 20, 185);
}
#userBtn {
  grid-column: 6/7;
}

img.user_icon {
  justify-self: flex-end;
  margin-left: 10px;
  width: 50px;
  height: 50px;
  background: rgb(12, 79, 223);
  border-radius: 60%;
  padding: 5px;
}

a {
  text-decoration: none;
}
button:hover {
  background-color: rgba(172, 101, 156, 0.5);
}
a:active {
  background-color: rgb(33, 12, 219);
}
</style>