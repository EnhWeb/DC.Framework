﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCardBenefitModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCardBenefitModifyModel : AlipayObject
    {
        /// <summary>
        /// 权益ID
        /// </summary>
        [JsonProperty("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 会员卡模板外部权益
        /// </summary>
        [JsonProperty("mcard_template_benefit")]
        public McardTemplateBenefit McardTemplateBenefit { get; set; }
    }
}
