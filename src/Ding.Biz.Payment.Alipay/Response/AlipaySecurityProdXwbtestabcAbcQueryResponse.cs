﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdXwbtestabcAbcQueryResponse.
    /// </summary>
    public class AlipaySecurityProdXwbtestabcAbcQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("xwb")]
        public string Xwb { get; set; }
    }
}
