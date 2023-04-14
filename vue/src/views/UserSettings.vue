<template>
   <div>
    <div id="settings">
      <p>User Settings</p>
        <div>
  <b-form @submit.stop.prevent>
    <label for="text-password">Current Password</label>
    <b-form-input type="password" id="text-password"></b-form-input>
    <label for="text-password">New Password</label>
    <b-form-input type="password" id="text-password" aria-describedby="password-help-block"></b-form-input>
    <b-form-text id="password-help-block">
      Your new password must be 8-20 characters long, contain letters and numbers, and must not
      contain spaces, special characters, or emoji.
    </b-form-text>
    <div class="submit">
      <button>Reset Password</button>
      </div>
   </b-form>
</div>
        </div>
  <form @submit.prevent="handleSubmit">
    <label>Name:</label>
    <input type="name" v-model="name"/>
    <label>Age:</label>
    <input type="age" v-model="age"/>
    <label>Genres:</label>
    <input type="text" v-model="tempGenre" @keyup.alt="addGenre"/>
    <div v-for="genre in favGenre" :key="genre" class="pill">
      <span @click="deleteGenre(genre)">{{genre}}</span>
      </div>
    <div class="divider">  
    <label>Favorite Movies:</label>
    <input type="movie" v-model="tempMovie" @keyup.alt="addMovie"/>
    <div v-for="movie in movies" :key="movie" class="pill">
      <span @click="deleteMovie(movie)">{{movie}}</span>
      </div>
      </div>
    <label>About Me:</label>
    <input type="info" v-model="info"/>
    <div class="submit">
      <button>Update Your Profile</button>
      </div>
    </form>
         <b-carousel
      id="carousel-1"
      v-model="slide"
      :interval="4000"
      controls
      indicators
      background="#ababab"
      img-width="1024"
      img-height="480"
      style="text-shadow: 1px 1px 2px #333;"
      @sliding-start="onSlideStart"
      @sliding-end="onSlideEnd"
    >
      <!-- Text slides with image -->
      <b-carousel-slide
        caption="First slide"
        text="Nulla vitae elit libero, a pharetra augue mollis interdum."
        img-src="https://picsum.photos/1024/480/?image=52"
      ></b-carousel-slide>

      <!-- Slides with custom text -->
      <b-carousel-slide img-src="https://picsum.photos/1024/480/?image=54">
        <h1>Hello world!</h1>
      </b-carousel-slide>

      <!-- Slides with image only -->
      <b-carousel-slide img-src="https://picsum.photos/1024/480/?image=58"></b-carousel-slide>

      <!-- Slides with img slot -->
      <!-- Note the classes .d-block and .img-fluid to prevent browser default image alignment -->
      <b-carousel-slide>
        <template #img>
          <img
            class="d-block img-fluid w-100"
            width="1024"
            height="480"
            src="https://picsum.photos/1024/480/?image=55"
            alt="image slot"
          >
        </template>
      </b-carousel-slide>

      <!-- Slide with blank fluid image to maintain slide aspect ratio -->
      <b-carousel-slide caption="Blank Image" img-blank img-alt="Blank image">
        <p>
          Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse eros felis, tincidunt
          a tincidunt eget, convallis vel est. Ut pellentesque ut lacus vel interdum.
        </p>
      </b-carousel-slide>
    </b-carousel>

    <p class="mt-4">
      Slide #: {{ slide }}<br>
      Sliding: {{ sliding }}
    </p>

     <b-form-file
      v-model="file1"
      :state="Boolean(file1)"
      placeholder="Choose a file or drop it here..."
      drop-placeholder="Drop file here..."
    ></b-form-file>
    <div class="mt-3">Selected file: {{ file1 ? file1.name : '' }}</div>

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
        age: '',
        name: '',
        tempGenre: [],
        favGenre: [],
        tempMovie: [],
        movies: [],
        info: ''
    };
  },
  methods: {
    addGenre (e) {
      if (e.key === ',' && this.tempGenre) {
        if (!this.favGenre.includes(this.tempGenre)) {
          this.favGenre.push(this.tempGenre)
        }
        this.tempGenre = ''
      }
    },
    deleteGenre (genre) {
      this.favGenre = this.favGenre.filter((item) => {
        return genre != item
      })
    },
    addMovie (e) {
      if (e.key === ',' && this.tempMovie) {
        if (!this.movies.includes(this.tempMovie)) {
          this.movies.push(this.tempMovie)
        }
        this.tempMovie = ''
      }
    },
    deleteMovie (movie) {
      this.movies = this.movies.filter((item) => {
        return movie != item
      })
    },
    handleSubmit() {
      console.log('Form submitted.')
      console.log('name: ', this.name)
      console.log('age ', this.age)
      console.log('Favorite Genres: ', this.favGenre)
      console.log('Favorite Movies: ', this.movies)
      console.log('info: ', this.info)

    }
  }
};
</script>

<style scoped>
#settings{
display: flex;
  flex-direction: column;
  height: 100vh;
  width: 100vw;
  margin: auto;
  justify-content: center;
  align-items: center;}

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
  color: #aaa;
  display: inline-block;
  margin: 25px 0 15px;
  font-size: 0.6em;
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
  color: #555;
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
    color: #777;
    cursor: pointer;
}
button {
    background: #0b6dff;
    border: 0;
    padding: 10px 20px;
    margin-top: 20px;
    color: white;
    border-radius: 20px;
}
.submit {
    text-align: center;
}
</style>