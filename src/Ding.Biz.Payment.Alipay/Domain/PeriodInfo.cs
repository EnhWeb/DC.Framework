﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// PeriodInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PeriodInfo : AlipayObject
    {
        /// <summary>
        /// 单位
        /// </summary>
        [JsonProperty("dimension")]
        public string Dimension { get; set; }

        /// <summary>
        /// 周期值
        /// </summary>
        [JsonProperty("value")]
        public long Value { get; set; }
    }
}
