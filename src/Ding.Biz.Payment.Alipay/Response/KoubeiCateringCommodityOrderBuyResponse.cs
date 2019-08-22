﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringCommodityOrderBuyResponse.
    /// </summary>
    public class KoubeiCateringCommodityOrderBuyResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展字段，供以后拓展使用
        /// </summary>
        [JsonProperty("ext_info")]
        public List<string> ExtInfo { get; set; }

        /// <summary>
        /// order_result为success时返回；order_result为fail的时候不返回
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// success表示订购成功；fail表示订购失败
        /// </summary>
        [JsonProperty("order_result")]
        public string OrderResult { get; set; }

        /// <summary>
        /// 描述订购结果信息
        /// </summary>
        [JsonProperty("order_result_msg")]
        public string OrderResultMsg { get; set; }
    }
}
