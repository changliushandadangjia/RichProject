using System;
using System.Collections.Generic;
using System.Text;
using Abp.Dependency;
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
        /// 添加
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

        public bool UpdateShareDealDetail()
        {

        }
    }
}
