using System;
using System.Collections.Generic;
using System.Text;
using Abp.Dependency;
using RichProjectDomain.Interface;
using RichProjectDomain.Interface.Query;
using RichProjectDomain.Model.DatabaseDto;

namespace RichProjectService.Service
{
    public class WealthDetailService:IWealthDetailService,ITransientDependency
    {
        private readonly IWealthDetailQuery _wealthDetailQuery;
        public WealthDetailService(IWealthDetailQuery wealthDetailQuery)
        {
            _wealthDetailQuery = wealthDetailQuery;
        }

        /// <summary>
        /// 根据Id获得财富详情
        /// </summary>
        /// <returns></returns>
        public WealthDetail GetWealthDetailById(int id)
        {
            return _wealthDetailQuery.GetWealthDetailById(id);
        }

        /// <summary>
        /// 获取财富详情
        /// </summary>
        /// <returns></returns>
        public List<WealthDetail> GetWealthDetail()
        {
            return _wealthDetailQuery.GetWealthDetail();
        }
    }
}
