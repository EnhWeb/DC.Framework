﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// ZolozIdentificationUserWebQueryResponse.
    /// </summary>
    public class ZolozIdentificationUserWebQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展结果
        /// </summary>
        [JsonProperty("extern_info")]
        public string ExternInfo { get; set; }
    }
}
