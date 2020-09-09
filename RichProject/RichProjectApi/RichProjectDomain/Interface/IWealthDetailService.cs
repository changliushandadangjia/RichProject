using System;
using System.Collections.Generic;
using System.Text;
using RichProjectDomain.Model.DatabaseDto;

namespace RichProjectDomain.Interface
{
    public interface IWealthDetailService
    {
        /// <summary>
        /// 根据Id获得财富详情
        /// </summary>
        /// <returns></returns>
        WealthDetail GetWealthDetailById(int id);

        /// <summary>
        /// 获取财富详情
        /// </summary>
        /// <returns></returns>
        List<WealthDetail> GetWealthDetail();

        /// <summary>
        /// 获取六个月内每月财富总额
        /// </summary>
        /// <returns></returns>
        List<MonthAmountSummary> GetMonthAmountSummary();

        /// <summary>
        /// 根据Id更新财富详情
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        bool UpdateWealthDetailById(WealthDetail input);

        /// <summary>
        /// 根据Id删除财富详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteWealthDetailById(int id);

        /// <summary>
        /// 根据Id删除财富详情
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        bool AddWealthDetail(WealthDetail input);
    }
}
