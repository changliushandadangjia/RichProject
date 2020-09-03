using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RichProjectAdmin.Domain.Model;

namespace RichProjectAdmin.Domain.Interface
{
    public interface IWealthDetailService
    {
        /// <summary>
        /// 获取所有财富详情
        /// </summary>
        /// <returns></returns>
        Task<List<WealthDetail>> GetWealthDetail();
    }
}
