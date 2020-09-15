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

        /// <summary>
        /// 获取六个月每月财富总和
        /// </summary>
        /// <returns></returns>
        Task<List<DetailAmountSummary>> GetMonthAmountSummary();

        /// <summary>
        /// 增加财富详情
        /// </summary>
        /// <param name="detail"></param>
        /// <returns></returns>
        Task<bool> AddWealthDetail(WealthDetail detail);


        /// <summary>
        /// 更新财富详情
        /// </summary>
        /// <returns></returns>
        Task<bool> UpdateWealthDetail(WealthDetail detail);

        /// <summary>
        /// 删除财富详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> DeleteWealthDetail(int id);
    }
}
