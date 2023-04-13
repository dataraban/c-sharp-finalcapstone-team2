<template>
  <div id="register" class="text-center">
    <form @submit.prevent="register">
      <h1>Create Account</h1>
      <div role="alert" v-if="registrationErrors">
        {{ registrationErrorMsg }}
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
      <div class="form-input-group">
        <label for="confirmPassword">Confirm Password</label>
        <input
          type="password"
          id="confirmPassword"
          v-model="user.confirmPassword"
          required
        />
      </div>
        <div>
    <b-form-checkbox
      id="checkbox-1"
      v-model="status"
      name="checkbox-1"
      value="Accepted"
      unchecked-value="Not Accepted"
    >
      <div class="popup" v-on:click="clickPopup()">I accept the terms and conditions:
        <span class="popuptext" id="termsPopup"><a>Please accept!</a></span>
        </div>
    </b-form-checkbox>

    <div>State: <strong>{{ status }}</strong></div>
  </div>
      
      <button type="submit" :disabled="!status">Create Account</button>
      <p>
        <router-link :to="{ name: 'login' }"
          >Already have an account? Log in.</router-link
        >
      </p>
    </form>
  </div>
</template>

<script>
import authService from "../services/AuthService";

export default {
  name: "register",
  data() {
    return {
      status: 'Not Accepted',
      user: {
        username: "",
        password: "",
        confirmPassword: "",
        role: "user",
      },
      registrationErrors: false,
      registrationErrorMsg: "There were problems registering this user.",
    };
  },
  methods: {
    register() {
      if (this.user.password != this.user.confirmPassword) {
        this.registrationErrors = true;
        this.registrationErrorMsg = "Password & Confirm Password do not match.";
      } else {
        authService
          .register(this.user)
          .then((response) => {
            if (response.status == 201) {
              this.$router.push({
                path: "/login",
                query: { registration: "success" },
              });
            }
          })
          .catch((error) => {
            const response = error.response;
            this.registrationErrors = true;
            if (response.status === 400) {
              this.registrationErrorMsg = "Bad Request: Validation Errors";
            }
          });
      }
    },
    clearErrors() {
      this.registrationErrors = false;
      this.registrationErrorMsg = "There were problems registering this user.";
    },
    clickPopup() {
      var popup = document.getElementById("termsPopup");
      popup.classList.toggle("show");
    }
  },
};
</script>

<style scoped>
#register {
  margin: auto;
  height: 100vh;
  width: 100vh;
  padding-top: 10vh;
  justify-items: center;
}
form {
  display: flex;
  flex-direction: column;
  align-items: center;
}
form h1 {
  padding-bottom: 5vh;
  width: 100%;
  white-space: nowrap;
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
  background-color: deeppink;
}
.popup {
    position: relative;
  display: inline-block;
  cursor: pointer;
}
.popup .popuptext {
  visibility: hidden;
  width: 160px;
  background-color: #555;
  color: #fff;
  text-align: center;
  border-radius: 6px;
  padding: 8px 0;
  position: absolute;
  z-index: 1;
  bottom: 125%;
  left: 50%;
  margin-left: -80px;
}

/* Popup arrow */
.popup .popuptext::after {
  content: "";
  position: absolute;
  top: 100%;
  left: 50%;
  margin-left: -5px;
  border-width: 5px;
  border-style: solid;
  border-color: #555 transparent transparent transparent;
}

/* Toggle this class when clicking on the popup container (hide and show the popup) */
.popup .show {
  visibility: visible;
  -webkit-animation: fadeIn 1s;
  animation: fadeIn 1s
}

/* Add animation (fade in the popup) */
@-webkit-keyframes fadeIn {
  from {opacity: 0;}
  to {opacity: 1;}
}

@keyframes fadeIn {
  from {opacity: 0;}
  to {opacity:1 ;}
}
</style>
