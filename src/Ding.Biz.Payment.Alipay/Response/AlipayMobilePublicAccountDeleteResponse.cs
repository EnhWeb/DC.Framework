﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicAccountDeleteResponse.
    /// </summary>
    public class AlipayMobilePublicAccountDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [JsonProperty("code")]
        public override string Code { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [JsonProperty("msg")]
        public override string Msg { get; set; }
    }
}
