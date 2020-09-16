using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Dependency;
using RichProjectDomain.Interface.Query;
using RichProjectDomain.Model.DatabaseDto;

namespace RichProjectDataAccess.Query
{
    public class LargePayDetailQuery:ILargePayDetailQuery,ITransientDependency
    {
        private readonly DataContext _dataContext;
        public LargePayDetailQuery(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        /// <summary>
        /// 获取大型支付详情列表
        /// </summary>
        /// <returns></returns>
        public List<LargePayDetail> GetLargePayDetail()
        {
            var wealthDetail = _dataContext.LargePayDetail.ToList();
            return wealthDetail;
        }
    }
}
