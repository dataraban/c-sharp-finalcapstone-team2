import axios from 'axios';

const apiService = axios.create({});

export default {

  listMovies() {
    return apiService.get('https://api.themoviedb.org/3/discover/movie?api_key=801560b2c5402810ded763d877958808');
  },

  getMovieById(id) {
    return apiService.get(`https://api.themoviedb.org/3/movie/${id}?api_key=801560b2c5402810ded763d877958808`);
  },

  // getMovieByGenre(genre) {
  //   //incorrect API call CHANGE THIS!
  //   return apiService.get(`https://api.themoviedb.org/3/${genre}/movie/list?api_key=801560b2c5402810ded763d877958808`);
  // },

  getAllGenres() {
    return apiService.get(`https://api.themoviedb.org/3/genre/movie/list?api_key=801560b2c5402810ded763d877958808`);
  },

  getMovieByPerson(person) {
    return apiService.get(`https://api.themoviedb.org/3/search/person?api_key=801560b2c5402810ded763d877958808&query=${person}`);
  },

  getMovieByMulti() {
    let url = "https://api.themoviedb.org/3/search/multi?api_key=801560b2c5402810ded763d877958808";
    for(let i = 0; i < arguments.length; i++) {
      arguments[i] = arguments[i].replace(/ /g,"+");
      url += ("&query=" + arguments[i]);
    }
    return apiService.get(url);
  },

  getMovieByKeyword(keyword) {
    return apiService.get(`https://api.themoviedb.org/3/search/keyword?api_key=801560b2c5402810ded763d877958808&query=${keyword}`);
  },



}