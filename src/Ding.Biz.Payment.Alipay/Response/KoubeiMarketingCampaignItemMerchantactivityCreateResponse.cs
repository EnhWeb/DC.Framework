﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityCreateResponse.
    /// </summary>
    public class KoubeiMarketingCampaignItemMerchantactivityCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 运营活动id
        /// </summary>
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }
    }
}
