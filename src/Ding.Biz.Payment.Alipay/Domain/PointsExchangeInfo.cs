﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// PointsExchangeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PointsExchangeInfo : AlipayObject
    {
        /// <summary>
        /// 兑换内容的ID
        /// </summary>
        [JsonProperty("ids")]
        public List<string> Ids { get; set; }

        /// <summary>
        /// 积分兑换内容的类型，比如券
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
