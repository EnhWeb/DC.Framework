﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingExchangevoucherUseResponse.
    /// </summary>
    public class AlipayMarketingExchangevoucherUseResponse : AlipayResponse
    {
        /// <summary>
        /// 被核销的券ID
        /// </summary>
        [JsonProperty("voucher_id")]
        public string VoucherId { get; set; }
    }
}
