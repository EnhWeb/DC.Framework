﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiTradeOrderEnterpriseSettleResponse.
    /// </summary>
    public class KoubeiTradeOrderEnterpriseSettleResponse : AlipayResponse
    {
        /// <summary>
        /// 描述本次返回中的业务属性，该字段用于描述本次返回中的业务属性，现有：BIZ_ALREADY_SUCCESS（幂等业务码）
        /// </summary>
        [JsonProperty("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 传入的商户订单号
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
