﻿using Ding.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceChinaremodelQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceChinaremodelQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 中再核保模型查询结果
        /// </summary>
        [JsonProperty("result")]
        public AlipayChinareModelResult Result { get; set; }
    }
}
