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
  box-sizing: border-box;
  background: hsla(339, 100%, 55%, 1);
  background: linear-gradient(
    90deg,
    hsla(339, 100%, 55%, 1) 0%,
    hsla(197, 100%, 64%, 1) 100%
  );
  background: -moz-linear-gradient(
    90deg,
    hsla(339, 100%, 55%, 1) 0%,
    hsla(197, 100%, 64%, 1) 100%
  );
  background: -webkit-linear-gradient(
    90deg,
    hsla(339, 100%, 55%, 1) 0%,
    hsla(197, 100%, 64%, 1) 100%
  );
  filter: progid: DXImageTransform.Microsoft.gradient( startColorstr="#FF1B6B", endColorstr="#45CAFF", GradientType=1 );
}
</style>
