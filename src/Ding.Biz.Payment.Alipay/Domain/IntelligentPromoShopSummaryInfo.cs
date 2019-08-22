﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// IntelligentPromoShopSummaryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IntelligentPromoShopSummaryInfo : AlipayObject
    {
        /// <summary>
        /// 门店id
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 全店名
        /// </summary>
        [JsonProperty("shop_name")]
        public string ShopName { get; set; }
    }
}
