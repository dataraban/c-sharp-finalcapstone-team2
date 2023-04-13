<template>
  <div>
    <search-bar />
    <input type="text" v-model="searchQuery" />
    <ul>
      <li v-for="item in filteredData" :key="item.id">
        {{ item.id }}
      </li>
    </ul>
  </div>
</template>

<script>
export default {
  name: "search-bar",
  data() {
    return {
      searchQuery: "",
    };
  },
  computed: {
    filteredData() {
      return this.data.filter((item) => {
        return item.movie
          .toLowerCase()
          .includes(this.searchQuery.toLowerCase());
      });
    },
  },
};
</script>

<style>
</style>