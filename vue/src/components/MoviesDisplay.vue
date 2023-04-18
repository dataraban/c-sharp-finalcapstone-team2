<template>
  <div>

    <div class="card card-flip" v-for="movie in movies" :key="movie.id" style="width: 15rem;">
      <!-- card front -->
    <div >

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
      <router-link class="text-center"
        v-bind:to="{ name: 'movie-details', params: { id: movie.id } }"
      >
      <button class="primary-button">Movie Details</button>
      </router-link>
    </p>
    </div>
    <!-- end card back -->
    </div>
  </div>
</template>

<script>
export default {
  name: "movies-display",
  props: {
    movies: [],
  },
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

li{
text-align: center;}

p{
overflow-wrap: break-word;}

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
  display: flex;
}

.card-front {
  transform: rotateY(0deg);
}

.card-back {
  transform: rotateY(180deg);
  position: absolute;
  top: 0;
}
.card-text{text-align: start;}
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
  background-color: dodgerblue;
  color: black;
  transform: rotateY(0deg);

}
</style>

