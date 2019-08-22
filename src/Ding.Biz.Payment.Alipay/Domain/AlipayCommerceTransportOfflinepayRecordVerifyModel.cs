﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportOfflinepayRecordVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportOfflinepayRecordVerifyModel : AlipayObject
    {
        /// <summary>
        /// 原始脱机记录信息
        /// </summary>
        [JsonProperty("record")]
        public string Record { get; set; }
    }
}
