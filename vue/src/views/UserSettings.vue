<template>
  <div>
    <div id="settings">
      <h1 id="header">User Settings</h1>
      <div>
        <b-form @submit.stop.prevent>
          <label for="text-password">Current Password</label>
          <b-form-input type="password" id="text-password"></b-form-input>
          <label for="text-password">New Password</label>
          <b-form-input
            type="password"
            id="text-password"
            aria-describedby="password-help-block"
          ></b-form-input>
          <b-form-text id="password-help-block">
            Your new password must be 8-20 characters long, contain letters and
            numbers, and must not contain spaces, special characters, or emoji.
          </b-form-text>
          <div class="submit">
            <button>Reset Password</button>
          </div>
        </b-form>
      </div>
    </div>
    <form @submit.prevent="handleSubmit">
      <label>Name:</label>
      <input type="name" v-model="name" />
      <label>Age:</label>
      <input type="age" v-model="age" />
      <label>Genres:</label>
      <input type="text" v-model="tempGenre" @keyup.alt="addGenre" />
      <div v-for="genre in favGenre" :key="genre" class="pill">
        <span @click="deleteGenre(genre)">{{ genre }}</span>
      </div>
      <div class="divider">
        <label>Favorite Movies:</label>
        <input type="movie" v-model="tempMovie" @keyup.alt="addMovie" />
        <div v-for="movie in movies" :key="movie" class="pill">
          <span @click="deleteMovie(movie)">{{ movie }}</span>
        </div>
      </div>
      <label>About Me:</label>
      <input type="info" v-model="info" />
      <div class="submit">
        <button>Update Your Profile</button>
      </div>
    </form>
    <br />
  </div>
</template>

<script>
export default {
  name: "user-settings",
  components: {},
  data() {
    return {
      file1: null,
      file2: null,
      age: "",
      name: "",
      tempGenre: [],
      favGenre: [],
      tempMovie: [],
      movies: [],
      info: "",
    };
  },
  methods: {
    addGenre(e) {
      if (e.key === "," && this.tempGenre) {
        if (!this.favGenre.includes(this.tempGenre)) {
          this.favGenre.push(this.tempGenre);
        }
        this.tempGenre = "";
      }
    },
    deleteGenre(genre) {
      this.favGenre = this.favGenre.filter((item) => {
        return genre != item;
      });
    },
    addMovie(e) {
      if (e.key === "," && this.tempMovie) {
        if (!this.movies.includes(this.tempMovie)) {
          this.movies.push(this.tempMovie);
        }
        this.tempMovie = "";
      }
    },
    deleteMovie(movie) {
      this.movies = this.movies.filter((item) => {
        return movie != item;
      });
    },
    handleSubmit() {
      console.log("Form submitted.");
      console.log("name: ", this.name);
      console.log("age ", this.age);
      console.log("Favorite Genres: ", this.favGenre);
      console.log("Favorite Movies: ", this.movies);
      console.log("info: ", this.info);
    },
  },
};
</script>

<style scoped>
#header {
  color: plum;
  -webkit-text-stroke-width: 1px;
  -webkit-text-stroke-color: black;
}
#settings {
  display: flex;
  flex-direction: column;
  margin: auto;
  justify-content: center;
  align-items: center;
}

#password-help-block {
  color: black;
}

form {
  max-width: 420px;
  margin: 30px auto;
  background: white;
  text-align: left;
  padding: 40px;
  border-radius: 10px;
}
label {
  color: rgb(0, 0, 0);
  display: inline-block;
  margin: 25px 0 15px;
  font-size: 12px;
  text-transform: uppercase;
  letter-spacing: 1px;
  font-weight: bold;
}
input {
  display: block;
  padding: 10px 6px;
  width: 100%;
  box-sizing: border-box;
  border: none;
  border-bottom: 1px solid #ddd;
  color: rgb(0, 0, 0);
}
.pill {
  display: inline-block;
  margin: 20px 10px 0 0;
  padding: 6px 12px;
  background: #eee;
  border-radius: 20px;
  font-size: 12px;
  letter-spacing: 1px;
  font-weight: bold;
  color: rgb(0, 0, 0);
  cursor: pointer;
}
button {
  background: plum;
  border: 0;
  padding: 10px 20px;
  margin-top: 20px;
  color: rgb(0, 0, 0);
  border-radius: 20px;
}
.submit {
  text-align: center;
}
</style>