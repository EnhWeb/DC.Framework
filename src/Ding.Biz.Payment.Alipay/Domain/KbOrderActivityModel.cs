﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// KbOrderActivityModel Data Structure.
    /// </summary>
    [Serializable]
    public class KbOrderActivityModel : AlipayObject
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }
    }
}
