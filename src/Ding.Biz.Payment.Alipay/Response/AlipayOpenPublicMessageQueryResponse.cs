﻿using System.Collections.Generic;
using Ding.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicMessageQueryResponse.
    /// </summary>
    public class AlipayOpenPublicMessageQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 发送消息结果集。仅返回该用户已发送的消息
        /// </summary>
        [JsonProperty("list")]
        public List<PublicMessageInfo> List { get; set; }
    }
}
