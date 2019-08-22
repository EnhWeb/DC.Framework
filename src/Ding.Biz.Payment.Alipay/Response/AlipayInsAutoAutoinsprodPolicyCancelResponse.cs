﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodPolicyCancelResponse.
    /// </summary>
    public class AlipayInsAutoAutoinsprodPolicyCancelResponse : AlipayResponse
    {
        /// <summary>
        /// 操作结果 true/false
        /// </summary>
        [JsonProperty("cancel_result")]
        public string CancelResult { get; set; }
    }
}
