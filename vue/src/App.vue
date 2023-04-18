<template>
  <div id="app">
    <nav-bar class="nav"></nav-bar>
    <router-view />

  </div>
</template>

<script>
import NavBar from "./components/NavBar.vue";


export default {
  components: { NavBar },
};</script>

<style scoped>
* {
  background-size: cover;
  box-sizing: border-box;
  background:  rgb(194, 3, 252) 0%,;
  background: linear-gradient(
    90deg,
     rgb(194, 3, 252) 0%,
    rgb(255, 155, 41) 100%
  );
  background: -moz-linear-gradient(
    90deg,
     rgb(194, 3, 252) 0%,
    rgb(255, 155, 41) 100%
  );
  background: -webkit-linear-gradient(
    90deg,
     rgb(194, 3, 252) 0%,
    rgb(255, 155, 41) 100%
  );
  filter: progid: DXImageTransform.Microsoft.gradient( startColorstr="#FF1B6B", endColorstr="#45CAFF", GradientType=1 );
  font-family: fantasy;
}
.nav{
  background: none;

}


</style>
