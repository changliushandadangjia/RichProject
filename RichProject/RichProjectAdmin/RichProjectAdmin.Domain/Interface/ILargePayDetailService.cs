using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RichProjectAdmin.Domain.Model;

namespace RichProjectAdmin.Domain.Interface
{
    public interface ILargePayDetailService
    {
        /// <summary>
        /// 获取大型支出详情
        /// </summary>
        /// <returns></returns>
        Task<List<LargePayDetail>> GetLargePayDetail();

        /// <summary>
        /// 增加大型支出详情
        /// </summary>
        /// <param name="detail"></param>
        /// <returns></returns>
        Task<bool> AddLargePayDetail(LargePayDetail detail);


        /// <summary>
        /// 更新大型支出详情
        /// </summary>
        /// <returns></returns>
        Task<bool> UpdateLargePayDetail(LargePayDetail detail);

        /// <summary>
        /// 删除大型支出详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> DeleteLargePayDetail(int id);
    }
}
