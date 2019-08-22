﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// SsdataDataserviceRiskAlixiaohaoQueryResponse.
    /// </summary>
    public class SsdataDataserviceRiskAlixiaohaoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否阿里小号
        /// </summary>
        [JsonProperty("is_alixiaohao")]
        public bool IsAlixiaohao { get; set; }
    }
}
