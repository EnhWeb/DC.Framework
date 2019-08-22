﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// IsvMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IsvMerchantInfo : AlipayObject
    {
        /// <summary>
        /// 商户pid
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 门店ID列表
        /// </summary>
        [JsonProperty("shop_ids")]
        public List<string> ShopIds { get; set; }
    }
}
