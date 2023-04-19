import axios from "axios";

export default {

    favoriteMovie(user) {
        return axios.post('/userFavorites', user)
    },
    ViewUsers() {
        return axios.get('/friendslist');
    },
    ViewComment() {
        return axios.get('/commentslist');
    }

}