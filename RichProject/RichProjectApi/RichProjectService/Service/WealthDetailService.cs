using System;
using System.Collections.Generic;
using System.Text;
using Abp.Dependency;
using RichProjectDomain.Interface;
using RichProjectDomain.Interface.Command;
using RichProjectDomain.Interface.Query;
using RichProjectDomain.Model.DatabaseDto;

namespace RichProjectService.Service
{
    public class WealthDetailService:IWealthDetailService,ITransientDependency
    {
        private readonly IWealthDetailQuery _wealthDetailQuery;
        private readonly IWealthDetailCommand _wealthDetailCommand;
        public WealthDetailService(IWealthDetailQuery wealthDetailQuery, IWealthDetailCommand wealthDetailCommand)
        {
            _wealthDetailQuery = wealthDetailQuery;
            _wealthDetailCommand = wealthDetailCommand;
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

        /// <summary>
        /// 获取六个月内每月财富总额
        /// </summary>
        /// <returns></returns>
        public List<MonthAmountSummary> GetMonthAmountSummary()
        {
            return _wealthDetailQuery.GetMonthAmountSummary();
        }

        /// <summary>
        /// 根据Id更新财富详情
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool UpdateWealthDetailById(WealthDetail input)
        {
            return _wealthDetailCommand.UpdateWealthDetailById(input);
        }

        /// <summary>
        /// 根据Id删除财富详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteWealthDetailById(int id)
        {
            return _wealthDetailCommand.DeleteWealthDetailById(id);
        }

        /// <summary>
        /// 根据Id删除财富详情
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool AddWealthDetail(WealthDetail input)
        {
            return _wealthDetailCommand.AddWealthDetail(input);
        }
    }
}
