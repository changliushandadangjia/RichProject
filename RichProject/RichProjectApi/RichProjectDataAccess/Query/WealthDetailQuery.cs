using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using Abp.Dependency;
using RichProjectDomain.Interface.Query;
using RichProjectDomain.Model.DatabaseDto;

namespace RichProjectDataAccess.Query
{
    public class WealthDetailQuery: IWealthDetailQuery,ITransientDependency
    {
        private readonly DataContext _dataContext;

        public WealthDetailQuery(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        /// <summary>
        /// 获取财富详情
        /// </summary>
        /// <returns></returns>
        public WealthDetail GetWealthDetail(int id)
        {
            var wealthDetail=_dataContext.WealthDetail.FirstOrDefault(p => p.Id == id);
            return wealthDetail;
        }
    }
}
