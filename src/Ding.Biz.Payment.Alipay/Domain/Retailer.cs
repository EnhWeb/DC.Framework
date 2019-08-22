﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// Retailer Data Structure.
    /// </summary>
    [Serializable]
    public class Retailer : AlipayObject
    {
        /// <summary>
        /// 零售商名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 零售商pid
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }
    }
}
