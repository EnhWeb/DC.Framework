﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicShortlinkCreateResponse.
    /// </summary>
    public class AlipayOpenPublicShortlinkCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 生成的带参推广短链接
        /// </summary>
        [JsonProperty("shortlink")]
        public string Shortlink { get; set; }
    }
}
