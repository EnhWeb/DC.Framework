﻿using System.Collections.Generic;
using Ding.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAccountExrateAllclientrateQueryResponse.
    /// </summary>
    public class AlipayAccountExrateAllclientrateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 汇率信息列表
        /// </summary>
        [JsonProperty("client_rate_list")]
        public List<ExClientRateVO> ClientRateList { get; set; }
    }
}
