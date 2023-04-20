<template>
<div class="jumpscare">
  <div class="skull" v-bind:class="{ jump: isActive, shake: isActive }"></div>
<div class="overlay can-hide"></div>
<div class="btn">Click me!</div>
</div>
</template>

<script>
export default {
data() {
    return {
    isActive: true
}
}
}
var audio = new Audio('http://soundbible.com/mp3/Female_Scream_Horror-NeoPhyTe-138499973.mp3');

setTimeout(function() { boo(); }, 2000);
setTimeout(function() { reset(); }, 4000);

function boo () {
    // <div class="skull" v-bind:class="{ jump: isActive, shake: isActive }"></div>
    // <div class="overlay can-hide" v-bind:class="{ hide: isActive }"></div>
//   ('.can-hide').addClass("hide"); 
//   ('.skull').addClass("jump");
//   ('.skull').addClass("shake");
  audio.play();
}

function reset() {
//   ('.can-hide').removeClass("hide"); 
//   ('.skull').removeClass("jump"); 
//   ('.skull').removeClass("shake");
}
</script>

<style>
html {
  background: black;
  overflow: hidden;
  font-family: "Oswald", sans-serif;
  -webkit-font-smoothing: antialiased;
  font-smoothing: antialiased;
}

.skull {
  background: url(https://s-media-cache-ak0.pinimg.com/236x/b1/8a/30/b18a30fff5579066ad989bed52fdd51a.jpg) center no-repeat;
  position: absolute;
  top: 0;
  bottom: 0;
  right: 0;
  left: 0;
  background-size: 350px Auto;
  z-index: 0;
}

.btn {
  margin: 0 auto;
  width: 170px;
  height: 60px;
  padding: 6px 0 0 3px;
  border: 2px solid #e6e6e6;
  border-radius: 2px;
  background: none;
  font-size: 16px;
  line-height: 54px;
  color: #fff;
  letter-spacing: .25em;
  text-decoration: none;
  font-weight: 600;
  text-transform: uppercase;
  vertical-align: middle;
  text-align: center;
  -webkit-appearance: none;
  -moz-appearance: none;
  appearance: none;
  -webkit-transition: background .4s, color .4s;
  transition: background .4s, color .4s;
  cursor: pointer;z-index: 10000;
  position: absolute;
  margin: auto;
  left: 0;
  right: 0;
  bottom: 15%;
}

.btn:hover {
  background: #e6e6e6;
  color: #10151B;
}

.jump {
  background-size: 800px Auto;
}

.overlay {
  background: url(http://il6.picdn.net/shutterstock/videos/5219735/thumb/1.jpg?i10c) center no-repeat;
  position: fixed;
  width: 100%;
  height: 100%;
  z-index: 1000;
  opacity: .1;
  background-size: cover;
  top: 0;
  left: 0;
}

.hide {
  display: none;
}

.can-hide {
  opacity: .1;
}

.shake {
  animation: shake 0.5s cubic-bezier(.36,.07,.19,.97) both;
}

@keyframes shake {
  10%, 90% {
    transform: translate3d(-12px, 0, 0);
  }
  
  20%, 80% {
    transform: translate3d(13px, 0, 0);
  }

  30%, 50%, 70% {
    transform: translate3d(-20px, 0, 0);
  }

  40%, 60% {
    transform: translate3d(20px, 0, 0);
  }
}
</style>