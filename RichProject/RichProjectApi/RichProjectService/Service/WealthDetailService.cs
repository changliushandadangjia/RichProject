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
        /// 获得财富详情
        /// </summary>
        /// <returns></returns>
        public WealthDetail GetWealthDetail(int id)
        {
            return _wealthDetailQuery.GetWealthDetail(id);
        }
    }
}
