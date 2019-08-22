﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeAgentCreateResponse.
    /// </summary>
    public class AlipayOpenPublicLifeAgentCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 外部入驻申请单据号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
