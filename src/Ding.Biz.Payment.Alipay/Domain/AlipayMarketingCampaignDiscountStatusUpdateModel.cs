﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountStatusUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignDiscountStatusUpdateModel : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonProperty("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 状态CAMP_PAUSED：暂停,CAMP_GOING 启动,CAMP_ENDED结束
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
