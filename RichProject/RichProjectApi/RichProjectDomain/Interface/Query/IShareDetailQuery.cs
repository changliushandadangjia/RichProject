using System;
using System.Collections.Generic;
using System.Text;
using RichProjectDomain.Model.DatabaseDto;
using RichProjectDomain.Model.InputModel;

namespace RichProjectDomain.Interface.Query
{
    public interface IShareDetailQuery
    {
        /// <summary>
        /// 根据条件获取
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        List<ShareDealDetail> GetShareDealDetail(ShareDetailQueryInputDto input);
    }
}
