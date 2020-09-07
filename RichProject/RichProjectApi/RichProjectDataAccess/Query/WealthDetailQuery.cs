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
        /// 根据Id获取财富详情
        /// </summary>
        /// <returns></returns>
        public WealthDetail GetWealthDetailById(int id)
        {
            var wealthDetail=_dataContext.WealthDetail.FirstOrDefault(p => p.Id == id);
            return wealthDetail;
        }

        /// <summary>
        /// 获取财富详情
        /// </summary>
        /// <returns></returns>
        public List<WealthDetail> GetWealthDetail()
        {
            var wealthDetail = _dataContext.WealthDetail.ToList();
            return wealthDetail;
        }

        /// <summary>
        /// 获取六个月内每月财富总额
        /// </summary>
        /// <returns></returns>
        public List<MonthAmountSummary> GetMonthAmountSummary()
        {
            DateTime startTime = Convert.ToDateTime(DateTime.Now.AddMonths(-6).ToString("yyyy-MM"));
            DateTime endTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM"));
            var summary = _dataContext.MonthAmountSummary.Where(p =>
                    Convert.ToDateTime(p.TimeFlag) <= endTime && Convert.ToDateTime(p.TimeFlag) >= startTime)
                .Select(p => p).ToList();
            return summary;
        }
    }
}
