<template>
  <div>
    <el-container style="height: 500px; border: 1px solid #eee">
      <el-aside width="200px" style="background-color: rgb(238, 241, 246)">
        <el-menu :default-openeds="['1', '3']">
          <el-submenu index="1">
            <template slot="title">
              <i class="el-icon-message"></i>股票模块
            </template>
            <el-menu-item-group>
              <!--<template slot='title'>股票交易详情</template>-->
              <el-menu-item index="1-1"><router-link  to="/BussinessDetail">股票交易详情</router-link></el-menu-item>
              <el-menu-item index="1-2"><router-link  to="/ShareSummary">股票综合统计</router-link></el-menu-item>
            </el-menu-item-group>
          </el-submenu>
        </el-menu>
      </el-aside>
      <slot>
      </slot>
      <el-container>
        <el-header style="text-align: right; font-size: 12px">
          <span>伟大的发明家</span>
        </el-header>
      </el-container>
    </el-container>
  </div>
</template>

<script>
export default {
  name: 'Layout',
  data () {
    return {}
  },
  mounted () {}
}
</script>

<style scoped>
</style>
