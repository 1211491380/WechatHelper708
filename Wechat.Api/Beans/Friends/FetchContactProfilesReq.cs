﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wechat.Api.Beans.Friends
{
    public class FetchContactProfilesReq
    {
        /// <summary>
        /// 好友的微信Id列表
        /// </summary>
        [Required]
        public IList<string> ContactWxIds { get; set; }
    }
}
