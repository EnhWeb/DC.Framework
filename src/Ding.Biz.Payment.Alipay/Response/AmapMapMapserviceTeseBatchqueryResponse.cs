﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AmapMapMapserviceTeseBatchqueryResponse.
    /// </summary>
    public class AmapMapMapserviceTeseBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("es")]
        public string Es { get; set; }
    }
}
