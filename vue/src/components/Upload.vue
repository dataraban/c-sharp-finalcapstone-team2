<template>
  <div class="upload">
      <input type="file" @change="onFileSelected">
      <button @click="onupLoad"></button>
      </div>
</template>

<script>
export default {
name: 'upload',
data () {
    return {
        selectedFile: null
    }
},
methods: {
    onFileSelected(event) {
        this.selectedFile = event.target.files[0]
        console.log(event)
    },
    onUpload() {

    }
}
}
</script>

<style>

</style>