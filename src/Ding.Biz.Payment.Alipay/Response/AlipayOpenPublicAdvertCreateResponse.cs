﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicAdvertCreateResponse.
    /// </summary>
    public class AlipayOpenPublicAdvertCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 广告位id
        /// </summary>
        [JsonProperty("advert_id")]
        public string AdvertId { get; set; }
    }
}
