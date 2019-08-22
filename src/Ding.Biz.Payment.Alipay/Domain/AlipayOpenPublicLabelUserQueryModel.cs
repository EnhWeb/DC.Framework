﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicLabelUserQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicLabelUserQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝用户的userid，2088开头长度为16位的字符串
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
