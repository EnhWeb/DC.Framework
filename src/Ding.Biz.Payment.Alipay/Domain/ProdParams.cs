﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// ProdParams Data Structure.
    /// </summary>
    [Serializable]
    public class ProdParams : AlipayObject
    {
        /// <summary>
        /// 预授权业务信息
        /// </summary>
        [JsonProperty("auth_biz_params")]
        public string AuthBizParams { get; set; }
    }
}
