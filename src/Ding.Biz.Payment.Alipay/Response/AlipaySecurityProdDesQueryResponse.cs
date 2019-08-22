﻿using Ding.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdDesQueryResponse.
    /// </summary>
    public class AlipaySecurityProdDesQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 11
        /// </summary>
        [JsonProperty("dee")]
        public GavintestNewLeveaOne Dee { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("string")]
        public string String { get; set; }
    }
}
