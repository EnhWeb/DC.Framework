﻿using Ding.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTrustUserRiskidentifyGetResponse.
    /// </summary>
    public class AlipayTrustUserRiskidentifyGetResponse : AlipayResponse
    {
        /// <summary>
        /// 行业关注名单识别结果
        /// </summary>
        [JsonProperty("ali_trust_risk_identify")]
        public AliTrustRiskIdentify AliTrustRiskIdentify { get; set; }
    }
}
