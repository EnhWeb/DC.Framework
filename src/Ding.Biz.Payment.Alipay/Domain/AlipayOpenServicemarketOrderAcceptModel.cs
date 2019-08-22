﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketOrderAcceptModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketOrderAcceptModel : AlipayObject
    {
        /// <summary>
        /// 服务商品订单ID
        /// </summary>
        [JsonProperty("commodity_order_id")]
        public string CommodityOrderId { get; set; }
    }
}
