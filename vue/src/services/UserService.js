import axios from "axios";

export default {

    favoriteMovie(user) {
        return axios.post('/userFavorites', user)
    },
    ViewUsers() {
        return axios.get('api/User');
    }

}