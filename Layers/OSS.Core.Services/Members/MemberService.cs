﻿#region Copyright (C) 2017 Kevin (OSS开源作坊) 公众号：osscoder

/***************************************************************************
*　　	文件功能描述：OSSCore服务层 —— 成员信息领域Service （前后台用户信息
*
*　　	创建人： Kevin
*       创建人Email：1985088337@qq.com
*    	创建日期：2017-6-4
*       
*****************************************************************************/

#endregion

using System.Threading.Tasks;
using OSS.Common.ComModels;
using OSS.Common.ComUtils;
using OSS.Core.Domains.Members.Interfaces;
using OSS.Core.Domains.Members.Mos;
using OSS.Core.Services.Members.Exchange;

namespace OSS.Core.Services.Members
{
    public class MemberService
    {
        /// <summary>
        /// 获取前台用户信息
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <returns></returns>
        public async Task<ResultMo<UserInfoMo>> GetUserInfo(long userId)
        {
            return await MemberCommon.GetUserInfo(userId);
        }

        /// <summary>
        ///  获取后台管理员信息
        /// </summary>
        /// <param name="adminId"></param>
        /// <returns></returns>
        public async Task<ResultMo<AdminInfoMo>> GetAdminInfo(long adminId)
        {
            return await InsContainer<IAdminInfoRep>.Instance.Get<AdminInfoMo>();
        }
    }
}
