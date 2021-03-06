﻿using System;
using System.Collections.Generic;
using System.Text;
using RichProjectDomain.Model.DatabaseDto;

namespace RichProjectDomain.Interface.Query
{
    public interface IWealthDetailQuery
    {
        /// <summary>
        /// 根据Id获取财富详情
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
    }
}
