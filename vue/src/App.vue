<template>
  <div id="app">
    <div id="nav">
      <router-link v-bind:to="{ name: 'home' }">Home</router-link>&nbsp;|&nbsp;
      <router-link v-bind:to="{ name: 'logout' }" v-if="$store.state.token != ''">Logout</router-link>
    </div>
    <input class="filter" type="text" v-model=filterText placeholder="Search..." />

    <router-view />
    <div>
      <search-bar/> 
      
    </div>
  </div>
  
</template>
<script>
import SearchBar from './components/SearchBar.vue'


export default {
  components: { SearchBar }
}
</script>


<style scoped>

#app {
  background: hsla(339, 100%, 55%, 1);

background: linear-gradient(90deg, hsla(339, 100%, 55%, 1) 0%, hsla(197, 100%, 64%, 1) 100%);

background: -moz-linear-gradient(90deg, hsla(339, 100%, 55%, 1) 0%, hsla(197, 100%, 64%, 1) 100%);

background: -webkit-linear-gradient(90deg, hsla(339, 100%, 55%, 1) 0%, hsla(197, 100%, 64%, 1) 100%);

filter: progid: DXImageTransform.Microsoft.gradient( startColorstr="#FF1B6B", endColorstr="#45CAFF", GradientType=1 );

}
</style>
