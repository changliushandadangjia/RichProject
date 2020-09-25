using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Dependency;
using Microsoft.EntityFrameworkCore;
using RichProjectDomain.Interface.Command;
using RichProjectDomain.Model.DatabaseDto;

namespace RichProjectDataAccess.Command
{
    public class ShareDetailCommand:IShareDetailCommand,ITransientDependency
    {
        private readonly DataContext _dataContext;

        public ShareDetailCommand(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        /// <summary>
        /// 添加股票交易详情
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool AddShareDealDetail(ShareDealDetail input)
        {
            input.CreationTime = DateTime.Now;
            input.LastModifycationTime = DateTime.Now;
            _dataContext.ShareDealDetail.Add(input);
            return _dataContext.SaveChanges() > 0;
        }

        /// <summary>
        /// 修改股票交易详情
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool UpdateShareDealDetail(ShareDealDetail input)
        {
            var detail = _dataContext.ShareDealDetail.FirstOrDefault(p => p.Id == input.Id);
            if (detail == null)
                return false;
            detail.StartPrice = input.StartPrice;
            detail.EndPrice = input.EndPrice;
            detail.BuyTime = input.BuyTime;
            detail.SaleTime = input.SaleTime;
            detail.ShareCode = input.ShareCode;
            detail.Name = input.Name;
            detail.ShareNumber = input.ShareNumber;
            detail.Amount = input.Amount;
            detail.Remark = input.Remark;
            detail.LastModifycationTime = DateTime.Now;
            _dataContext.ShareDealDetail.Update(detail);
            return _dataContext.SaveChanges() > 0;
        }
    }
}
