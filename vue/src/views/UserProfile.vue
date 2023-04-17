<template>
    
    <!-- <div id="profilePage">
      <div id="profilePhoto">
        <upload/>
        </div>
    </div> -->
    <div id="profilePage">
      User Profile
      <div id="profileHeader">
      <div id="profilePhoto">
        <img src="https://www.graphicdesignforum.com/uploads/default/original/2X/6/6536ac7514627aa2238ef7a0dbb5585d9189d701.jpeg" alt="W3Schools.com">
        </div>
        <div id="basicInfo">
        <label class="infos">Name: {{Name}}</label> <br>
        <label class="infos">Age: {{Age}} </label> <br>
        <label class="infos">Favorite Genres: {{Genres}} </label> <br>
        <label class="infos">Favorite Movies: {{Movies}} </label>
        </div>
        </div>
        <div id="reviews">
          <p>This movie was good.</p>
          <p>This movie was bad.</p>
      </div>
      <label class="comments">Comments:</label>
      <textarea class="comments" name="comments" rows="4" cols="50">
        </textarea>
      </div>
</template>
<script>
// import Upload from '../components/Upload.vue'
export default {
  name: "user-profile",
  components: { },
  data() {
    return {};
  },
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

  #profilePhoto {
    height: 150px;
    width: 150px;
  }

  img {
    width: 100%;
    height: 100%;
  }

  #profileHeader {
    display: flex;
    align-items: center;
  }
  .infos {
    margin-bottom: 30px;
    margin-left: 15px;
  }

  .comments {
    width: 750px;
    text-align: center;
  }
</style>