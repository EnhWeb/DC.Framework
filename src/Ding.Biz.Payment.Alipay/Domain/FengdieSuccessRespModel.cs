﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieSuccessRespModel Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieSuccessRespModel : AlipayObject
    {
        /// <summary>
        /// 判断请求操作是否成功，值为 true 或者 false
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
