using System;
using System.Collections.Generic;
using System.Text;
using RichProjectDomain.Model.DatabaseDto;

namespace RichProjectDomain.Interface.Query
{
    public interface IWealthDetailQuery
    {
        /// <summary>
        /// 获取财富详情
        /// </summary>
        /// <returns></returns>
        WealthDetail GetWealthDetail(int id);
    }
}
