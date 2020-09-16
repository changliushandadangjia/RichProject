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
    public class LargePayDetailCommand: ILargePayDetailCommand, ITransientDependency
    {
        private readonly DataContext _dataContext;

        public LargePayDetailCommand(DataContext dbContext)
        {
            _dataContext = dbContext;
        }

        /// <summary>
        /// 根据Id更新大型支出详情
        /// </summary>
        /// <returns></returns>
        public bool UpdateLargePayDetailById(LargePayDetail input)
        {
            var detail = _dataContext.LargePayDetail.AsNoTracking().FirstOrDefault(p => p.Id == input.Id);
            if (detail == null)
                return false;
            detail.PayName = input.PayName;
            detail.Amount = input.Amount;
            detail.Remark = input.Remark;
            detail.LastModifycationTime=DateTime.Now;
            _dataContext.LargePayDetail.Update(detail);
            return _dataContext.SaveChanges() > 0;
        }

        /// <summary>
        /// 根据Id删除大型支出详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteLargePayDetailById(int id)
        {
            var detail = _dataContext.LargePayDetail.FirstOrDefault(p => p.Id == id);
            if (detail == null)
                return false;
            detail.IsDeleted = true;
            _dataContext.LargePayDetail.Update(detail);
            return _dataContext.SaveChanges() > 0;
        }

        /// <summary>
        /// 新增大型支出详情
        /// </summary>
        /// <param name="detail"></param>
        /// <returns></returns>
        public bool AddLargePayDetail(LargePayDetail detail)
        {
            detail.CreationTime = DateTime.Now;
            detail.LastModifycationTime = DateTime.Now;
            _dataContext.LargePayDetail.Add(detail);
            return _dataContext.SaveChanges() > 0;
        }
    }
}
