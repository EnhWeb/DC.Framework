﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// InsClaimPolicy Data Structure.
    /// </summary>
    [Serializable]
    public class InsClaimPolicy : AlipayObject
    {
        /// <summary>
        /// 保单号
        /// </summary>
        [JsonProperty("policy_no")]
        public string PolicyNo { get; set; }
    }
}
