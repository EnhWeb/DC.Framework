﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskContentDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskContentDetectModel : AlipayObject
    {
        /// <summary>
        /// 需要识别的文本，不要包含特殊字符以及双引号等可能引起json格式化错误问题的字符.
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }
    }
}
