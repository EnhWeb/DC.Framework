﻿using System.Collections.Generic;
using Ding.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringCrowdgroupConditionSetResponse.
    /// </summary>
    public class KoubeiCateringCrowdgroupConditionSetResponse : AlipayResponse
    {
        /// <summary>
        /// 创建成功返回isv创建的分组规则列表
        /// </summary>
        [JsonProperty("condition_model_list")]
        public List<ConditionItemPattern> ConditionModelList { get; set; }

        /// <summary>
        /// isv创建的用户分组id
        /// </summary>
        [JsonProperty("crowd_group_id")]
        public string CrowdGroupId { get; set; }

        /// <summary>
        /// 创建状态: success fail
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
