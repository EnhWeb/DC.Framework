﻿using Ding.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesCreateResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSitesCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 创建站点的返回值模型
        /// </summary>
        [JsonProperty("data")]
        public FengdieActivityCreateModel Data { get; set; }
    }
}
