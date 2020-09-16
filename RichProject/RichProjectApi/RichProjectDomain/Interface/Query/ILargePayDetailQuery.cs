using System;
using System.Collections.Generic;
using System.Text;
using RichProjectDomain.Model.DatabaseDto;

namespace RichProjectDomain.Interface.Query
{
    public interface ILargePayDetailQuery
    {
        /// <summary>
        /// 获取大型支付详情列表
        /// </summary>
        /// <returns></returns>
        List<LargePayDetail> GetLargePayDetail();
    }
}
