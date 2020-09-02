using System;
using System.Collections.Generic;
using System.Text;
using RichProjectDomain.Model.DatabaseDto;

namespace RichProjectDomain.Interface
{
    public interface IWealthDetailService
    {
        /// <summary>
        /// 获得财富详情
        /// </summary>
        /// <returns></returns>
        WealthDetail GetWealthDetail(int id);
    }
}
