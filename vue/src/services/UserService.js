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
    AddFavoriteMovie(usermovie){
        console.log(usermovie);
        // let usermovie = {UserId: userid, MovieId: movieid};
        return axios.post(`/Favorites/userMovie/`, usermovie)
    },
    PostComment(comment) {
        return axios.post('/commentslist', comment);
    }

}