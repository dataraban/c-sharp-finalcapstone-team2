<template>
  <div id="login">
    <form @submit.prevent="login">
      <div role="alert" v-if="invalidCredentials">
        Invalid username and password!
      </div>
      <div role="alert" v-if="this.$route.query.registration">
        Thank you for registering, please sign in.
      </div>
      <div class="form-input-group">
        <label for="username">Username</label>
        <input
          type="text"
          id="username"
          v-model="user.username"
          required
          autofocus
        />
      </div>
      <div class="form-input-group">
        <label for="password">Password</label>
        <input type="password" id="password" v-model="user.password" required />
      </div>
      <button type="submit">Sign in</button>
      <p>
        <router-link class="needAcct" :to="{ name: 'register' }"
          >Need an account? Sign up.</router-link
        >
      </p>
    </form>
  </div>
</template>

<script>
import authService from "../services/AuthService";

export default {
  name: "login",
  components: {},
  data() {
    return {
      user: {
        username: "",
        password: "",
      },
      invalidCredentials: false,
    };
  },
  methods: {
    login() {
      authService
        .login(this.user)
        .then((response) => {
          if (response.status == 200) {
            this.$store.commit("SET_AUTH_TOKEN", response.data.token);
            this.$store.commit("SET_USER", response.data.user);
            this.$router.push("/");
          }
        })
        .catch((error) => {
          const response = error.response;

          if (response.status === 401) {
            this.invalidCredentials = true;
          }
        });
    },
  },
};
</script>

<style scoped>
#login {
  margin: auto;
  height: 100vh;
  width: 100vh;
  padding-top: 10vh;
  display: flex;
  flex-direction: column;
  align-items: center;
  text-align: center;
}
h1 {
  padding-bottom: 5vh;
  width: 100%;
  white-space: nowrap;
  text-align: center;
}
label {
  width: 10vw;
  white-space: nowrap;
  text-align: left;
}
input {
  margin-bottom: 3vh;
  background-color: darkorange;
}
button {
  margin-top: 5vh;
  margin-bottom: 5vh;
  max-width: fit-content;
  background-color: rgb(167, 16, 167);
}
.needAcct {
  color: rgb(0,0,0);
}
.nav{display: none;}
</style>