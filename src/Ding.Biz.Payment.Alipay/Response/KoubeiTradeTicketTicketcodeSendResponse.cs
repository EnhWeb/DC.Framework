﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiTradeTicketTicketcodeSendResponse.
    /// </summary>
    public class KoubeiTradeTicketTicketcodeSendResponse : AlipayResponse
    {
        /// <summary>
        /// 该字段用于描述本次返回中的业务属性，现有：BIZ_ALREADY_SUCCESS（幂等业务码）。
        /// </summary>
        [JsonProperty("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }
}
