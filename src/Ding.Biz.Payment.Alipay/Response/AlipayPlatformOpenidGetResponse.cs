﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPlatformOpenidGetResponse.
    /// </summary>
    public class AlipayPlatformOpenidGetResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [JsonProperty("code")]
        public override string Code { get; set; }

        /// <summary>
        /// id字典，key为userId和老的openId，value为新的openId
        /// </summary>
        [JsonProperty("dict")]
        public string Dict { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [JsonProperty("msg")]
        public override string Msg { get; set; }
    }
}
