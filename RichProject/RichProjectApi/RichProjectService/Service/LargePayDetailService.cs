using System;
using System.Collections.Generic;
using System.Text;
using Abp.Dependency;
using RichProjectDomain.Interface;
using RichProjectDomain.Interface.Command;
using RichProjectDomain.Interface.Query;
using RichProjectDomain.Model.DatabaseDto;

namespace RichProjectService.Service
{
    public class LargePayDetailService : ILargePayDetailService, ITransientDependency
    {
        private readonly ILargePayDetailQuery _largePayDetailQuery;
        private readonly ILargePayDetailCommand _largePayDetailCommand;
        public LargePayDetailService(ILargePayDetailCommand largePayDetailCommand, ILargePayDetailQuery largePayDetailQuery)
        {
            _largePayDetailCommand = largePayDetailCommand;
            _largePayDetailQuery = largePayDetailQuery;
        }

        /// <summary>
        /// 查询大型支出
        /// </summary>
        /// <returns></returns>
        public List<LargePayDetail> GetLargePayDetail()
        {
            return _largePayDetailQuery.GetLargePayDetail();
        }

        /// <summary>
        /// 根据Id更新大型支出
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool UpdateLargePayDetailById(LargePayDetail input)
        {
            return _largePayDetailCommand.UpdateLargePayDetailById(input);
        }

        /// <summary>
        /// 根据Id删除大型支出
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteLargePayDetailById(int id)
        {
            return _largePayDetailCommand.DeleteLargePayDetailById(id);
        }

        /// <summary>
        /// 根据Id删除大型支出
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool AddLargePayDetail(LargePayDetail input)
        {
            return _largePayDetailCommand.AddLargePayDetail(input);
        }
    }
}
