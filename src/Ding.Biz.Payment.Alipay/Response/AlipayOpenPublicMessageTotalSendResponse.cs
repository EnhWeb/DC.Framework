﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicMessageTotalSendResponse.
    /// </summary>
    public class AlipayOpenPublicMessageTotalSendResponse : AlipayResponse
    {
        /// <summary>
        /// 消息ID
        /// </summary>
        [JsonProperty("message_id")]
        public string MessageId { get; set; }
    }
}
