import Vue from 'vue'
import VueRouter from 'vue-router'
import BussinessDetail from '../views/BussinessDetail.vue'
import ShareSummary from '../views/ShareSummary.vue'
Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'BussinessDetail',
    component: BussinessDetail
  },
  {
    path: '/BussinessDetail',
    name: 'BussinessDetail',
    component: BussinessDetail
  },
  {
    path: '/ShareSummary',
    name: 'ShareSummary',
    component: ShareSummary
  }
]

const router = new VueRouter({
  mode: 'hash', // history
  base: process.env.BASE_URL,
  routes
})

export default router
