﻿using System;
using System.Collections.Generic;
using System.Text;
using RichProjectDomain.Model.DatabaseDto;

namespace RichProjectDomain.Interface.Command
{
    public interface ILargePayDetailCommand
    {
        /// <summary>
        /// 根据Id更新大型支出详情
        /// </summary>
        /// <returns></returns>
        bool UpdateLargePayDetailById(LargePayDetail input);

        /// <summary>
        /// 根据Id删除大型支出详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteLargePayDetailById(int id);

        /// <summary>
        /// 新增大型支出详情
        /// </summary>
        /// <param name="detail"></param>
        /// <returns></returns>
        bool AddLargePayDetail(LargePayDetail detail);
    }
}
