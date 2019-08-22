﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// InteligentGeneralMerchantPromo Data Structure.
    /// </summary>
    [Serializable]
    public class InteligentGeneralMerchantPromo : AlipayObject
    {
        /// <summary>
        /// 营销活动的id，如merchant_promo_type：CONSUME_SEND即消费送的活动id
        /// </summary>
        [JsonProperty("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 圈人限制条件
        /// </summary>
        [JsonProperty("crowd_constraint")]
        public CrowdConstraintInfo CrowdConstraint { get; set; }

        /// <summary>
        /// 活动描述信息，该信息有可能会在店铺详情页漏出，请自己填写
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 活动扩展信息
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 营销活动预测效果
        /// </summary>
        [JsonProperty("forecast_effect")]
        public IntelligentPromoEffect ForecastEffect { get; set; }

        /// <summary>
        /// 活动预算
        /// </summary>
        [JsonProperty("inteligent_budget")]
        public InteligentBudgetInfo InteligentBudget { get; set; }

        /// <summary>
        /// 活动限制信息
        /// </summary>
        [JsonProperty("inteligent_constraint")]
        public InteligentConstraintInfo InteligentConstraint { get; set; }

        /// <summary>
        /// 营销工具集合。主要是活动涉及到的奖品信息
        /// </summary>
        [JsonProperty("inteligent_promo_tools")]
        public List<InteligentPromoTool> InteligentPromoTools { get; set; }

        /// <summary>
        /// 投放渠道信息
        /// </summary>
        [JsonProperty("inteligent_publish_channels")]
        public List<InteligentPublishChannel> InteligentPublishChannels { get; set; }

        /// <summary>
        /// 营销活动类型；枚举（DIRECT_SEND：直发奖；CONSUME_SEND：消费送）
        /// </summary>
        [JsonProperty("merchant_promo_type")]
        public string MerchantPromoType { get; set; }

        /// <summary>
        /// 营销活动名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 子营销活动对应的模板id
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }
    }
}
