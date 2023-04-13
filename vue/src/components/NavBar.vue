<template>
  <div id="nav">
    <button id="homeBtn">
      <router-link class="home" v-bind:to="{ name: 'home' }">Home</router-link>
    </button>
    <button id="logoutBtn">
      <router-link
        class="logout"
        v-bind:to="{ name: 'logout' }"
        v-if="$store.state.token != ''"
        >Logout</router-link
      >
    </button>
    <button id="forYouBtn">
      <router-link v-bind:to="{ name: 'playlist' }">For You</router-link>
    </button>

    <div class="genredropdown">
      <button id="genreBtn" href="#">
        <router-link v-bind:to="{ name: 'genre' }">Genres</router-link>
         
      </button>
      <div class="dropdown-content">
       <router-link v-for="genre in genres" :key="genre.id" v-bind:to="{name: 'genre-id', params: {id: genre.id}}">
      {{ genre.name }}
     </router-link>
      </div>
    </div>

    <search-bar class="search">Search:</search-bar>
    <input
      class="filter"
      type="text"
      v-model="filteredData"
      placeholder="Search Here"
    />
    <button id="userBtn">
      <router-link v-bind:to="{ name: 'user-profile' }">
        Welcome User</router-link
      >

      <!-- want to be able to input the logged in users name in here-->
      <img
        class="user_icon"
        src="https://upload.wikimedia.org/wikipedia/commons/9/99/Sample_User_Icon.png"
      />
    </button>

    <router-view />
    <div>
      <search-bar />
    </div>
  </div>
</template>

<script>
import SearchBar from "./SearchBar.vue";
import MoviesService from '../services/MoviesService'
export default {
  components: { SearchBar },
  data() {
        return {
            genres: []
        }
    },
    created() {    
        MoviesService.getAllGenres().then((response) => {
        this.genres = response.data.genres;
        });
    }
}
</script>


<style scoped>
#nav {
  display: grid;
  width: 100%;
  height: 100%;
  grid-template-columns: repeat(6, 1fr);
  grid-template-rows: 2, 1fr;
  padding: 10px;
  font-size: 100%;
  font-family: fantasy;
  background-color: rgb(210, 130, 230);
}
button {
  border-width: 1px;
  border-color: pink;
  border-top: none;
  border-bottom: none;
  display: flex;
  align-items: center;
  justify-content: center;
  color: rgb(50, 20, 185);
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
#forYouBtn {
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
}
.dropdown-content a {
  float: none;
  display: block;
  text-align: left;
  padding: 12px 16px;
  color: black;
}
.genredropdown:hover .dropdown-content {
  display: block;
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
  background-color: rgba(107, 141, 216, 0.5);
}
a:active {
  background-color: rgb(33, 12, 219);
}
</style>