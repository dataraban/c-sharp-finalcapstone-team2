<template>
  <div>
    <div class="card card-flip" v-bind:class="{ 'favorite': movie.favorite }" v-for="movie in $store.state.movies" :key="movie.id" style="width: 15rem;">
      <!-- card front -->
      
    <div>
      <div><span class="toggleMe"/></div>
        <img
          :src="'https://image.tmdb.org/t/p/w185' + movie.poster_path" @error="$event.target.src=getImgUrl()"
        />
      <!-- </router-link> -->

      <h5 class="card-body">{{ getMovieTitle(movie) }}        
      </h5>
      <!-- <h6 class="card-body">{{ movie.release_date }}        
      </h6> -->
    </div>
    <!-- end card front -->
    
    <!-- card back -->
    <div class="card-back">
      <p class="card-text">
      {{ movie.overview }}
      </p>
      <router-link class="text-center" v-bind:to="{ name: 'movie-details', params: { id: movie.id } }"
      >
      <p><button class="btn btn-primary">Movie Details</button></p>
      </router-link>

    <!-- <button :class="favoriteToggleButtonClass" v-on:click="ToggleFavoriteMovie">Favorite {{ favoriteToggleButtonText }}</button> -->
    <button type="button" class="btn btn-warning" data-toggle="button" aria-pressed="false" autocomplete="off" v-on:click="ToggleFavoriteStatus($event,movie)">{{ FavoriteButtonText(movie)}}</button>
    </div>
    <!-- end card back -->
    </div>
  </div>
</template>

<script>
import UserService from "../services/UserService";
export default {
  name: "movies-display",
  methods: {
    getImgUrl() {
      return require('../assets/noposter.jpg')
    },
    getMovieTitle(movie){
      if(movie.title !== undefined){
        return movie.title;
      }
      else if(movie.name !== undefined){
        return movie.name;
      }
      else if(movie.original_name !== undefined){
        return movie.original_name;
      }
      return movie.title ? movie.title : "Title Not Found";
    },
    ToggleFavoriteStatus(event,movie) {
      this.$store.commit('TOGGLE_FAVORITE', movie);
      let UserId = this.$store.state.user.userId;
      // thisUser = 1;
      let MovieId = movie.id;
      UserService.AddFavoriteMovie({UserId, MovieId});

      //don't touch this garbage  
      const node = event.target.parentNode.parentNode.querySelector("span.toggleMe");
      if(movie.favorite === true){
        // node.innerText = "Favorited";
        node.parentNode.parentNode.parentNode.style.backgroundColor = "gold";
      }
      else {
        // node.innerText = "";
        
        node.parentNode.parentNode.parentNode.style.backgroundColor = "white";
      }
    },
    FavoriteToggleCardColor(movie) {
      return movie.favorite ? "bg-warning" : "bg-light";
    },
    FavoriteButtonText(movie){
      return movie.favorite ? "Unfavorite" : "Favorite";
    }
  }
};
</script>

<style scoped>
div {
  display: flex;
  flex-wrap: wrap;
  padding-top: 2vh;
  justify-content: center;
}
.card{
  margin: 1%;
  text-align: center;
  }
 .card-flip > div {
  backface-visibility: hidden;
  transition: transform 300ms;
  transition-timing-function: linear;
  perspective: 1000px;
  width: 100%;
  height: 100%;
  margin: 0;
}
.card-front {
  transform: rotateY(0deg);
}
.card-back {
  transform: rotateY(180deg);
  position: absolute;
  top: 0;
  display: flex;
  flex-wrap: wrap;
  padding-right: 15%;
  padding-left: 15%;
}
.card-text
{text-align: start;}
.flip-card-inner {
  position: relative;
  width: 100%;
  height: 100%;
  transition: transform 0.8s;
  transform-style: preserve-3d;
}
.card-flip:hover .card-front {
  transform: rotateY(-180deg);
}
  
.card-flip:hover .card-back {
  background-color: rgb(224, 137, 241);
  color: black;
  transform: rotateY(0deg);
  overflow: auto;
}
.text-center {
  text-decoration: none;
}
.movie-details {
  display: flex;
  align-content: center;
}

div.favorite {
    background-color: gold;
    text-emphasis: bold;
}

</style>

