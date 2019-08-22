﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCardBenefitCreateResponse.
    /// </summary>
    public class AlipayMarketingCardBenefitCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 权益ID
        /// </summary>
        [JsonProperty("benefit_id")]
        public string BenefitId { get; set; }
    }
}
