<template>
  <div id="jumpscare">
      Hello!
<span></span>
  </div>

</template>

<script>
export default {

}
</script>

<style>
@import url('https://fonts.googleapis.com/css2?family=Rock+Salt&display=swap');
body
{
  background-color: rgb(0, 0, 0);
  background-size: cover;
  background-image: linear-gradient(#888, #000 25%);
  background-position: center;
  background-repeat: no-repeat;
  display: flex;
  justify-content: center;
  align-items: center;
  height: 90vh;
  color: #fff;
  cursor: none;
  overflow: hidden;
}
#jumpscare
{
  position: absolute;
  inset: 0;
  display: grid;
  justify-content: center;
  align-items: center;
  font-family: sans-serif;
  transition: 1000ms ease-in-out;
  background-color: rgb(0, 0, 0);
}
div::before
{
  content: "Hello World";
  font-family: 'Rock Salt', cursive;
  position: absolute;
  display: grid;
  justify-content: center;
  align-items: center;
  inset: 0;
  color: #bb0a1e;
  opacity: 0;
  transition: 1000ms ease-in-out;
  z-index: -1;
  text-shadow: 0 0.8rem 0.4rem #bb0a1e;
  transform: translateY(5vh);
}
div::after
{
  content: "";
  position: absolute;
  display: grid;
  justify-content: center;
  align-items: center;
  inset: 0;
  background-image: url("https://wallpaperaccess.com/full/1505299.jpg");
  background-position: center;
  background-size: cover;
  opacity: 0;
  transition: 1000ms ease-in-out;
  z-index: 100;
}
div:hover::after
{
  animation: jump-scare 5s ease-in-out infinite;
}
@keyframes jump-scare
{
  0%, 90%, 100%
  {
    opacity: 0;
  }
  91%
  {
    opacity: 1;
  }
}
div:hover
{
  transform: translateY(-5vh);
  color: #000;
  background-color: transparent;
}
div:hover::before
{
  opacity: 1;
}
span
{
  position: absolute;
  top: 25%;
  left: 50%;
  transform: translateX(-50%);
  width: 25vw;
  height: 25vw;
  border-radius: 50% 50% 25% 25% / 50%;
  background-color: #fff;
  opacity: 0;
  transition: 1000ms ease-in-out;
  box-shadow: 0 20px 20px #bb0a1e;
  animation: ghost-float 2.5s ease-in-out infinite;
}
@keyframes ghost-float
{
  0%, 100%
  {
    transform: translateY(-10px) translateX(-50%);
  }
  50%
  {
    transform: translateY(0px) translateX(-50%);
  }
}
body:hover > span
{
  opacity: 0.5;   
}
span::before
{
  content: "";
  position: absolute;
  background-color: #000;
  background-image: radial-gradient(#bb0a1e, #000 25%);
  width: 25%;
  aspect-ratio: 1/1;
  border-radius: 50%;
  top: 25%;
  left: 15%;
  transform: scaleY(2) rotateZ(55deg);
  animation: eye-glow 1s ease-in-out infinite;
}
span::after
{
  content: "";
  position: absolute;
  background-color: #000;
  background-image: radial-gradient(#bb0a1e, #000 25%);
  width: 25%;
  aspect-ratio: 1/1;
  border-radius: 50%;
  top: 25%;
  right: 15%;
  transform: scaleY(2) rotateZ(55deg);
  animation: eye-glow 1s ease-in-out infinite;
}
@keyframes eye-glow
{
  0%, 100%
  {
    box-shadow: 0 0 0 #bb0a1e;
  }   
  50%
  {
    box-shadow: 0 0 16px #bb0a1e, inset 0 0 16px #bb0a1e;
  } 
}
</style>