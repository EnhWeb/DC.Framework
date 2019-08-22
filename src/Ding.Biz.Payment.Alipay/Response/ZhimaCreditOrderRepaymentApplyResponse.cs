﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditOrderRepaymentApplyResponse.
    /// </summary>
    public class ZhimaCreditOrderRepaymentApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 请求时传入外部单据号，结果中带回
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 判断调用是否成功
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
