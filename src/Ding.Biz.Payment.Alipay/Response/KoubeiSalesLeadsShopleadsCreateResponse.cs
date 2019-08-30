﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiSalesLeadsShopleadsCreateResponse.
    /// </summary>
    public class KoubeiSalesLeadsShopleadsCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 导入成功的LeadsId
        /// </summary>
        [JsonProperty("leads_id")]
        public string LeadsId { get; set; }
    }
}