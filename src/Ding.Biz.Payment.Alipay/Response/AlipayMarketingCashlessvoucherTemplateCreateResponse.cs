﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCashlessvoucherTemplateCreateResponse.
    /// </summary>
    public class AlipayMarketingCashlessvoucherTemplateCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }
    }
}
