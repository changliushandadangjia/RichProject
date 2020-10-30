<template>
  <div>
    <Layout>
      <el-main>
        <el-table :data="tableData">
          <el-table-column prop="id" label="编号"> </el-table-column>
          <el-table-column prop="name" label="股票名称"> </el-table-column>
          <el-table-column prop="shareCode" label="股票代码"> </el-table-column>
          <el-table-column prop="startPrice" label="起始价格">
          </el-table-column>
          <el-table-column prop="endPrice" label="卖出价格"> </el-table-column>
          <el-table-column prop="shareNumber" label="股数"> </el-table-column>
          <el-table-column prop="amount" label="金额"> </el-table-column>
          <el-table-column prop="remark" label="备注"> </el-table-column>
          <el-table-column prop="buyTime" label="买入时间"> </el-table-column>
          <el-table-column prop="saleTime" label="卖出时间"> </el-table-column>
        </el-table>
      </el-main>
    </Layout>
  </div>
</template>

<script>
// import $ from "jquery";
import Layout from '../components/Layout'
export default {
  name: 'BussinessDetail',
  data () {
    return {
      tableData: []
    }
  },
  mounted () {
    this.$axios({
      url: '/GetShareDealDetail',
      method: 'post',
      data: {
        startTime: '2020-01-01',
        endTime: '2020-12-31',
        name: '嘎嘎',
        shareCode: '600258'
      }
    }).then((res) => {
      this.tableData = res.data
    })
  },
  components: {
    Layout: Layout
  }
}
</script>

<!-- Add 'scoped' attribute to limit CSS to this component only -->
<style scoped>
</style>
