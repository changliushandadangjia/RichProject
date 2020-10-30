module.exports = {
  devServer: {
    proxy: {
      '/': {
        target: 'https://localhost:44399/',
        ws: true,
        changeOrigin: true
      }
    }
  }
}
