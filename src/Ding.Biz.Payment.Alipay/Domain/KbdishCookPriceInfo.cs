﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishCookPriceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishCookPriceInfo : AlipayObject
    {
        /// <summary>
        /// 菜单id
        /// </summary>
        [JsonProperty("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 菜品id
        /// </summary>
        [JsonProperty("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 会员价，目前已废弃
        /// </summary>
        [JsonProperty("member_price")]
        public string MemberPrice { get; set; }

        /// <summary>
        /// 售卖价格
        /// </summary>
        [JsonProperty("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// skuid
        /// </summary>
        [JsonProperty("sku_id")]
        public string SkuId { get; set; }
    }
}
