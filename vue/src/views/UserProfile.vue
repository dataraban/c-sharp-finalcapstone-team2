<template>
  <!-- <div id="profilePage">
      <div id="profilePhoto">
        <upload/>
        </div>
    </div> -->
  <div id="profilePage">
    <h1 id="profileHeading">User Profile</h1>
    <div id="profileHeader">
      <div id="profilePhoto">
        <img
          src="https://www.graphicdesignforum.com/uploads/default/original/2X/6/6536ac7514627aa2238ef7a0dbb5585d9189d701.jpeg"
          alt="W3Schools.com"
        />
      </div>
      <div id="basicInfo">
        <label class="infos">Name: Josephina {{ Name }}</label> <br />
        <label class="infos">Age: 27 {{ Age }} </label> <br />
        <label class="infos"
          >Favorite Genres: Suspense, Action, Comedy{{ Genres }}
        </label>
        <br />
        <label class="infos"
          >Favorite Movies: The Lion King, Silence of the Lambs, Wall-E{{
            Movies
          }}
        </label>
      </div>
    </div>
    <div id="reviews">
      <div class="card text-right">
        <div class="card-body">
          <p>Your reviews:</p>
          <p>This movie was good.</p>
          <p>This movie was bad.</p>
        </div>
      </div>
    </div>
    <div class="friend-list">
      <div class="card text-right">
        <div class="card-body">
          <p class="card text-right">Select a Friend</p>
          <p>Friends List:</p>
          <div v-for="user in users" v-bind:key="user.id">{{ user }}</div>
        </div>
      </div>
    </div>
    <div class="insert-comment">
    <label class="comments">Comments:</label>
    </div>
    <form @submit.prevent="handleSubmit" >
    <div class="text-center">
      <textarea @submit.prevent="handleSubmit" class="commentArea" name="comments" rows="4" cols="50" v-model="comment">
      </textarea>
    </div>
    <button class="submit">Submit</button>
    </form>
    <div id="comment-section">
      <div class="card text-right">
        <div class="card-body">
          <p>Your Feed</p>
          <label class="card text-right">Name: {{ Name }}</label>
          <p>Wow, can we be friends?</p>
           <div v-for="comment in comments" v-bind:key="comment.id">{{ comment }}</div>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
// import Upload from '../components/Upload.vue'
import UserService from "../services/UserService";
export default {
  name: "user-profile",
  components: {},
  data() {
    return {
      users: [],
      comments: [],
      comment: ""
    };
  },
  methods: {
    handleSubmit() {
    console.log("Form submitted.");
    }
  },
  created() {
    UserService.ViewUsers().then((response) => {
      this.users = response.data;
    }),
    UserService.ViewComment().then((response) => {
      this.comments = response.data;
    });
  },
};
</script>
<style scoped>
#profilePage {
  display: flex;
  flex-direction: column;
  margin: auto;
  justify-content: center;
}
#profileHeading {
  padding-top: 2%;
  display: flex;
  justify-content: center;
  color: plum;
  -webkit-text-stroke-width: 1px;
  -webkit-text-stroke-color: black;
  font-family: fantasy;
}
#profilePhoto {
  height: 250px;
  width: 250px;
}
img {
  width: 100%;
  height: 100%;
  border-radius: 50%;
}
#profileHeader {
  display: flex;
  align-items: center;
  justify-content: center;
  padding-top: 2%;
  padding-bottom: 2%;
}
.infos {
  padding-top: 10px;
  padding-left: 10px;
  margin-bottom: 30px;
}
#basicInfo {
  margin-left: 10px;
  background: white;
   width: 500px;
   border-radius: 10px;
}
#reviews {
  width: 750px;
  margin: auto;
  padding-bottom: 2%;
}
.insert-comment {
  background-color: white;
  border-radius: 10px;
  width: 750px;
  text-align: center;
  display: flex;
  justify-content: center;
  margin: auto;
}
.commentArea {
  width: 750px;
  padding-bottom: 2%;
  border-radius: 10px;
}
.reviews {
  display: flex;
  align-content: center;
  justify-content: center;
}
.friend-list {
  width: 750px;
  margin: auto;
  padding-bottom: 2%;
}
#comment-section {
  width: 750px;
  margin: auto;
}
</style>