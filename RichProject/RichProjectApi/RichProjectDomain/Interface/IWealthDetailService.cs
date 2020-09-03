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
    }
}
