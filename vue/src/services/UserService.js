import axios from "axios";

export default {

    favoriteMovie(user) {
        return axios.get(`/Favorites/userMovie/${user}`);
    },
    ViewUsers() {
        return axios.get('/friendslist');
    },
    ViewComment() {
        return axios.get('/commentslist');
    }

}