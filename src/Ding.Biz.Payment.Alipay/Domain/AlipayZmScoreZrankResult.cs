﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayZmScoreZrankResult Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayZmScoreZrankResult : AlipayObject
    {
        /// <summary>
        /// 芝麻分分段 Z0-Z7
        /// </summary>
        [JsonProperty("zrank")]
        public string Zrank { get; set; }
    }
}
