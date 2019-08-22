﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketCommodityShopOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketCommodityShopOfflineModel : AlipayObject
    {
        /// <summary>
        /// 服务商户ID
        /// </summary>
        [JsonProperty("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
