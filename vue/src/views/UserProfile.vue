<template>
    
    <div id="profilePage">
      <div id="profilePhoto">
        <upload/>
        </div>
    </div>
</template>
<script>
import Upload from '../components/Upload.vue'
export default {
  name: "user-profile",
  components: { Upload  },
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

  #profilePhoto {
    height: 150px;
    width: 150px;
  }
</style>