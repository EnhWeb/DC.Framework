﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicAccountQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝账号userid，2088开头长度为16位的字符串
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
