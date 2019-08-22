﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingUserulePidQueryResponse.
    /// </summary>
    public class AlipayMarketingUserulePidQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 满足条件的所有pid，多个pid使用英文逗号隔开
        /// </summary>
        [JsonProperty("pids")]
        public string Pids { get; set; }
    }
}
