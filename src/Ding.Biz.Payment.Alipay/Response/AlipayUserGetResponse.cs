﻿using Ding.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserGetResponse.
    /// </summary>
    public class AlipayUserGetResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝用户信息
        /// </summary>
        [JsonProperty("alipay_user_detail")]
        public AlipayUserDetail AlipayUserDetail { get; set; }
    }
}
