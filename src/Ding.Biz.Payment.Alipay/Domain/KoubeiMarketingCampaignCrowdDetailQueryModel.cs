﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignCrowdDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignCrowdDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 人群组ID，人群组创建成功时返回的ID
        /// </summary>
        [JsonProperty("crowd_group_id")]
        public string CrowdGroupId { get; set; }
    }
}
