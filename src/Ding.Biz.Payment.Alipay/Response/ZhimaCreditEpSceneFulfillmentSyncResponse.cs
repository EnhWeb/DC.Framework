﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditEpSceneFulfillmentSyncResponse.
    /// </summary>
    public class ZhimaCreditEpSceneFulfillmentSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 履约单号
        /// </summary>
        [JsonProperty("fulfillment_order_no")]
        public string FulfillmentOrderNo { get; set; }
    }
}
