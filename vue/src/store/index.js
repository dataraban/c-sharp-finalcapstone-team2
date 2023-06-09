import Vue from 'vue'
import Vuex from 'vuex'
import axios from 'axios'

Vue.use(Vuex)

/*
 * The authorization header is set for axios when you login but what happens when you come back or
 * the page is refreshed. When that happens you need to check for the token in local storage and if it
 * exists you should set the header so that it will be attached to each request
 */
const currentToken = localStorage.getItem('token')
const currentUser = JSON.parse(localStorage.getItem('user'));

if(currentToken != null) {
  axios.defaults.headers.common['Authorization'] = `Bearer ${currentToken}`;
}

export default new Vuex.Store({
  state: {
    token: currentToken || '',
    user: currentUser || {},
    currentGenreId: 0,
    movies: []
  },
  mutations: {
    SET_AUTH_TOKEN(state, token) {
      state.token = token;
      localStorage.setItem('token', token);
      axios.defaults.headers.common['Authorization'] = `Bearer ${token}`
    },
    SET_USER(state, user) {
      state.user = user;
      localStorage.setItem('user',JSON.stringify(user));
    },
    LOGOUT(state) {
      localStorage.removeItem('token');
      localStorage.removeItem('user');
      state.token = '';
      state.user = {};
      axios.defaults.headers.common = {};
    },
    CHANGE_GENRE_ID(state, newGenreId) {
      state.currentGenreId = newGenreId;
    },
    UPDATE_MOVIES(state, newMovies) {
      state.movies = newMovies;
      state.movies.forEach((movie) => {
        movie.favorite = false;
      })
    },
    TOGGLE_FAVORITE(state, favoriteMovie){
      // let newFavorite = state.movies.find((movie) => {
      //   return movie.id === favoriteMovie.id
      // })
      // newFavorite.favorite = !newFavorite.favorite;
      favoriteMovie.favorite = !favoriteMovie.favorite;
    }
    
    // ADD_PLAYLIST(state, review) {
    //   state.reviews.unshift(review); working on these for the watch list page
    // },
    // ADD_WATCHLIST(state, review) {
    //   state.reviews.unshift(review);
    // } 
  }
})
