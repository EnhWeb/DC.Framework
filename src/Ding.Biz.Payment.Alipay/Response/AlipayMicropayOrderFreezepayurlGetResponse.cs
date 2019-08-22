﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMicropayOrderFreezepayurlGetResponse.
    /// </summary>
    public class AlipayMicropayOrderFreezepayurlGetResponse : AlipayResponse
    {
        /// <summary>
        /// 支付冻结金的地址
        /// </summary>
        [JsonProperty("pay_freeze_url")]
        public string PayFreezeUrl { get; set; }
    }
}
