﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeOrderPrecreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiTradeOrderPrecreateModel : AlipayObject
    {
        /// <summary>
        /// 业务类型，当前支持：POST_ORDER_PAY 点餐后付订单支付码生成
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 外部订单号，即请求方订单的唯一标识。  当biz_type传入POST_ORDER_PAY时，该字段为必选
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 请求id，唯一标识一次请求，根据该字段请求幂等
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 口碑侧的门店id。  当biz_type传入POST_ORDER_PAY时，该字段为必选
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
