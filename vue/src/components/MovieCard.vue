<template>
  <div class="card">
    <h2 class="movie-title">{{ movie.title }}</h2>
    <!--Get movie image -->
    <div class="movie-deets">
    <router-link
      v-bind:to="{ name: 'movie-details', params: { id: movie.id } }"
    >
      {{ movie.title }}
    </router-link>
    </div>
    <!-- <img v-if="book.isbn" v-bind:src="'http://covers.openlibrary.org/b/isbn/' + book.isbn + '-M.jpg'" />
    <h3 class="book-author">{{ book.author }}</h3>
    <div class="button-container" v-if="! enableAdd">
        <button class="mark-read" v-on:click.prevent="setRead(true)" v-if=" ! book.read">Mark Read</button>
        <button class="mark-unread" v-on:click.prevent="setRead(false)" v-if="book.read">Mark Unread</button>
    </div>
    <button v-if="enableAdd" v-on:click.prevent="addToReadingList(book)">Add to Reading List</button> -->
  </div>
</template>

<script>
export default {
  name: "movie-card",
  props: {
    movie: Object,
  },
  methods: {
    // setRead(value) {
    //     this.$store.commit('SET_READ_STATUS', {book: this.book, value: value});
    // },
    // addToReadingList(book) {
    //     let addedBook = Object.assign({ read: false }, book);
    //     delete addedBook.bestSeller;
    //     delete addedBook.newRelease;
    //     this.$store.commit('SAVE_BOOK', addedBook);
    // }
  },
};
</script>

<style>
.card {
  border: 2px solid black;
  border-radius: 10px;
  width: 250px;
  height: 550px;
  margin: 20px;
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
   
}

.card .movie-title {
  font-size: 1.5rem;
  font-family: fantasy;
}
.card .movie-deets{
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  align-content: center;
  font-family: fantasy;
  overflow: scroll;
  box-sizing: border-box;
  
}

</style>