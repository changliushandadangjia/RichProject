using System;
using System.Collections.Generic;
using System.Text;
using Abp.Dependency;
using RichProjectDomain.Interface;
using RichProjectDomain.Interface.Command;
using RichProjectDomain.Interface.Query;
using RichProjectDomain.Model.DatabaseDto;
using RichProjectDomain.Model.InputModel;

namespace RichProjectService.Service
{
    public class ShareDetailService: IShareDetailService,ITransientDependency
    {
        private readonly IShareDetailQuery _shareDetailQuery;
        private readonly IShareDetailCommand _shareDetailCommand;

        public ShareDetailService(IShareDetailQuery shareDetailQuery, IShareDetailCommand shareDetailCommand)
        {
            _shareDetailQuery = shareDetailQuery;
            _shareDetailCommand = shareDetailCommand;
        }

        /// <summary>
        /// 获取股票交易详情
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<ShareDealDetail> GetShareDealDetail(ShareDetailQueryInputDto input)
        {
            return _shareDetailQuery.GetShareDealDetail(input);
        }

        /// <summary>
        /// 添加交易记录
        /// </summary>
        /// <returns></returns>
        public bool AddShareDealDetail(ShareDealDetail detail)
        {
            return _shareDetailCommand.AddShareDealDetail(detail);
        }
        
        /// <summary>
        /// 更新交易记录
        /// </summary>
        /// <param name="detail"></param>
        /// <returns></returns>
        public bool UpdateShareDealDetail(ShareDealDetail detail)
        {
            return _shareDetailCommand.UpdateShareDealDetail(detail);
        }
    }
}
