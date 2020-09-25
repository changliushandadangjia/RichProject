using System;
using System.Collections.Generic;
using System.Text;
using RichProjectDomain.Model.DatabaseDto;
using RichProjectDomain.Model.InputModel;

namespace RichProjectDomain.Interface
{
    public interface IShareDetailService
    {
        /// <summary>
        /// 获取股票交易详情
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        List<ShareDealDetail> GetShareDealDetail(ShareDetailQueryInputDto input);

        /// <summary>
        /// 添加交易记录
        /// </summary>
        /// <returns></returns>
        bool AddShareDealDetail(ShareDealDetail detail);

        /// <summary>
        /// 更新交易记录
        /// </summary>
        /// <param name="detail"></param>
        /// <returns></returns>
        bool UpdateShareDealDetail(ShareDealDetail detail);
    }
}
