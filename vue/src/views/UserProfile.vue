<template>
    
    <!-- <div id="profilePage">
      <div id="profilePhoto">
        <upload/>
        </div>
    </div> -->
    <div id="profilePage">
      <div id="profileHeading">
      User Profile
      </div>
      <div id="profileHeader">
      <div id="profilePhoto">
        <img src="https://www.graphicdesignforum.com/uploads/default/original/2X/6/6536ac7514627aa2238ef7a0dbb5585d9189d701.jpeg" alt="W3Schools.com">
        </div>
        <div id="basicInfo">
        <label class="infos">Name: Josephina {{Name}}</label> <br>
        <label class="infos">Age: 27 {{Age}} </label> <br>
        <label class="infos">Favorite Genres: Suspense, Action, Comedy{{Genres}} </label> <br>
        <label class="infos">Favorite Movies: The Lion King, Silence of the Lambs, Wall-E{{Movies}} </label>
        </div>
        </div>
        <div id="reviews">
          <p>This movie was good.</p>
          <p>This movie was bad.</p>
      </div>
      <div class="card text-right">
        AA
        <div class="card-body">
          <p class="card text-right">Some text</p>
          <p>Friends List:</p>
          <div v-for="user in users" v-bind:key="user.id">{{user}}
            </div>
        </div>
        </div>
      <label class="comments">Comments:</label>
      <div class="text-center">
      <textarea class="commentArea" name="comments" rows="4" cols="50">
        </textarea>
        </div>
        <div id="mockComments">
          <label class="userComment">Name: {{Name}}</label>
          <p>Wow, can we be friends?</p>
          </div>
      </div>
</template>
<script>
// import Upload from '../components/Upload.vue'
import UserService from "../services/UserService";
export default {
  name: "user-profile",
  components: { },
  data() {
    return {
    users:[]
  };
  },
  created() {
    UserService.ViewUsers().then((response) => {
      this.users = response.data;
    });
  }
};
</script>
<style scoped>
#profilePage{
display: flex;
  flex-direction: column;
  height: 100vh;
  width: 100vw;
  margin: auto;
  justify-content: center;}

  #profileHeading {
    display: flex;
    justify-content: center;
    font-size: 30px;
  }

  #profilePhoto {
    height: 345px;
    width: 225x;
    border: 1px solid black;
  }

  img {
    width: 100%;
    height: 100%;
  }

  #profileHeader {
    display: flex;
    align-items: center;
    justify-content: center;
  }
  .infos {
    margin-bottom: 30px;
    padding: 15px;
    width: 450px;
  }

  #basicInfo {
    border: 5px solid green;
    margin-left: 10px;
  }

#reviews {
  border: 5px solid black;
  margin-top: 10px;
  padding: 50px;
}

  .comments {
    text-align: center;
    margin-top: 20px;
    padding-top: 20px;
    justify-content: center;
  }

  .commentArea {
    width: 750px;
  }

</style>