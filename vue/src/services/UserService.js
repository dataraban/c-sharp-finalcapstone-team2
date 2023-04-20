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
    },
    AddFavoriteMovie(userId, movieId){
        return axios.post(`/Favorites/userMovie/${userId}`, {userId,movieId})
    },
    PostComment() {
        return axios.post('/commentslist');
    }

}