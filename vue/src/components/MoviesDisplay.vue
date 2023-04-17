<template>
  <div>
    <div class="card card-flip" v-for="movie in movies" :key="movie.id" style="width: 15rem;">
      <!-- card front -->
    <div >

        <img
          v-bind:src="'https://image.tmdb.org/t/p/w185' + movie.poster_path"
        />
      <!-- </router-link> -->

      <h5 class="card-body">{{ movie.original_title }}        
      </h5>
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

