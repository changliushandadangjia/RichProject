using System;
using System.Collections.Generic;
using System.Text;
using RichProjectDomain.Model.DatabaseDto;

namespace RichProjectDomain.Interface.Command
{
    public interface IShareDetailCommand
    {
        /// <summary>
        /// 添加股票交易详情
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        bool AddShareDealDetail(ShareDealDetail input);

        /// <summary>
        /// 修改股票交易详情
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        bool UpdateShareDealDetail(ShareDealDetail input);
    }
}
