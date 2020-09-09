using System;
using System.Linq;
using Abp.Dependency;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RichProjectDomain.Interface.Command;
using RichProjectDomain.Model.DatabaseDto;

namespace RichProjectDataAccess.Command
{
    public class WealthDetailCommand: IWealthDetailCommand,ITransientDependency
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public WealthDetailCommand(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        /// <summary>
        /// 根据Id更新财富详情
        /// </summary>
        /// <returns></returns>
        public bool UpdateWealthDetailById(WealthDetail input)
        {
            var detail = _dataContext.WealthDetail.AsNoTracking().FirstOrDefault(p => p.Id == input.Id);
            if (detail == null)
                return false;
            int detailId = detail.Id;
            DateTime createTime = detail.CreationTime;
            detail = _mapper.Map<WealthDetail>(input);
            detail.Id = detailId;
            detail.LastModifycationTime = DateTime.Now;
            detail.CreationTime = createTime;
            _dataContext.WealthDetail.Update(detail);
            return _dataContext.SaveChanges() > 0;
        }

        /// <summary>
        /// 根据Id删除财富详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteWealthDetailById(int id)
        {
            var detail = _dataContext.WealthDetail.FirstOrDefault(p => p.Id == id);
            if (detail == null)
                return false;
            detail.IsDeleted = true;
            _dataContext.WealthDetail.Update(detail);
            return _dataContext.SaveChanges() > 0;
        }

        /// <summary>
        /// 新增财富详情
        /// </summary>
        /// <param name="detail"></param>
        /// <returns></returns>
        public bool AddWealthDetail(WealthDetail detail)
        {
            detail.CreationTime=DateTime.Now;
            detail.LastModifycationTime=DateTime.Now;
            _dataContext.WealthDetail.Add(detail);
            return _dataContext.SaveChanges() > 0;
        }
    }
}
