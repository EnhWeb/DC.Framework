﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignCertCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignCertCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 凭证id
        /// </summary>
        [JsonProperty("lot_number")]
        public string LotNumber { get; set; }
    }
}
