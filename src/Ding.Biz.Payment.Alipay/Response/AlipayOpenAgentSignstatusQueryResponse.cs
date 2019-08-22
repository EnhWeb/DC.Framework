﻿using System.Collections.Generic;
using Ding.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAgentSignstatusQueryResponse.
    /// </summary>
    public class AlipayOpenAgentSignstatusQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商户产品签约状态结果对象数组，返回本次查询的产品的签约状态
        /// </summary>
        [JsonProperty("sign_status_list")]
        public List<ProductSignStatusInfo> SignStatusList { get; set; }
    }
}
