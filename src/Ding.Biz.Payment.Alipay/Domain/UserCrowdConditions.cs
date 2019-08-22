﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// UserCrowdConditions Data Structure.
    /// </summary>
    [Serializable]
    public class UserCrowdConditions : AlipayObject
    {
        /// <summary>
        /// 最爱这家店的人
        /// </summary>
        [JsonProperty("crowd_group_id")]
        public string CrowdGroupId { get; set; }

        /// <summary>
        /// 用户群组描述
        /// </summary>
        [JsonProperty("describe")]
        public string Describe { get; set; }

        /// <summary>
        /// 命中用户规则集合
        /// </summary>
        [JsonProperty("hit_crowd_conditons")]
        public List<ConditionItemPattern> HitCrowdConditons { get; set; }
    }
}
