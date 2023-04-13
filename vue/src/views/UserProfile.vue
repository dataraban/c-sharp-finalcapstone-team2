<template>
    <div>
    <nav-bar class="nav"></nav-bar>
    <div id="profilePage">
        
    </div>

    </div>
</template>
<script>
import NavBar from "../components/NavBar.vue";
export default {
  name: "user-profile",
  components: { NavBar },
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
  justify-content: center;
  align-items: center;}
</style>