﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// ContributeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ContributeDetail : AlipayObject
    {
        /// <summary>
        /// 出资方金额
        /// </summary>
        [JsonProperty("contribute_amount")]
        public string ContributeAmount { get; set; }

        /// <summary>
        /// 出资方类型，如品牌商出资、支付宝平台出资等
        /// </summary>
        [JsonProperty("contribute_type")]
        public string ContributeType { get; set; }
    }
}
