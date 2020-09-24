using System.Collections.Generic;
using System.Linq;
using Abp.Dependency;
using RichProjectDomain.Interface.Query;
using RichProjectDomain.Model.DatabaseDto;
using RichProjectDomain.Model.InputModel;

namespace RichProjectDataAccess.Query
{
    public class ShareDetailQuery: IShareDetailQuery,ITransientDependency
    {
        private readonly DataContext _dataContext;
        public ShareDetailQuery(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        /// <summary>
        /// 根据条件获取
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<ShareDealDetail> GetShareDealDetail(ShareDetailQueryInputDto input)
        {
            if (!string.IsNullOrWhiteSpace(input.ShareCode))
            {
                return _dataContext.ShareDealDetail.Where(p => p.ShareCode == input.ShareCode).ToList();
            }
            if (!string.IsNullOrWhiteSpace(input.Name))
            {
                return _dataContext.ShareDealDetail.Where(p => p.Name == input.Name).ToList();
            }
            return _dataContext.ShareDealDetail.Where(p => p.BuyTime >= input.StartTime && p.SaleTime <= input.EndTime)
                .ToList();
        }
    }
}
