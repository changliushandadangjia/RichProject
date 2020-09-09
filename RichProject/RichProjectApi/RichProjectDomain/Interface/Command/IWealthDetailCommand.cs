using System;
using System.Collections.Generic;
using System.Text;
using RichProjectDomain.Model.DatabaseDto;

namespace RichProjectDomain.Interface.Command
{
    public interface IWealthDetailCommand
    {
        /// <summary>
        /// 新增财富详情
        /// </summary>
        /// <param name="detail"></param>
        /// <returns></returns>
        bool AddWealthDetail(WealthDetail detail);

        /// <summary>
        /// 根据Id删除财富详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteWealthDetailById(int id);

        /// <summary>
        /// 根据Id更新财富详情
        /// </summary>
        /// <returns></returns>
        bool UpdateWealthDetailById(WealthDetail input);
    }
}
