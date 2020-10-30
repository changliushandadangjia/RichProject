import Vue from 'vue'
import App from './App.vue'
import './registerServiceWorker'
import router from './router'
import store from './store'
import ElementUI from 'element-ui'
import axios from 'axios'
import 'element-ui/lib/theme-chalk/index.css'

Vue.config.productionTip = false
Vue.prototype.$axios = axios

// axios.defaults.headers.post['Content-Type'] = 'application/json;charset=UTF-8'

// Vue.prototype.$qs = qs
Vue.use(ElementUI, axios)
new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
