﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// KbOrderShopModel Data Structure.
    /// </summary>
    [Serializable]
    public class KbOrderShopModel : AlipayObject
    {
        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名
        /// </summary>
        [JsonProperty("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 00007
        /// </summary>
        [JsonProperty("store_id")]
        public string StoreId { get; set; }
    }
}
