﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// MemberActionModel Data Structure.
    /// </summary>
    [Serializable]
    public class MemberActionModel : AlipayObject
    {
        /// <summary>
        /// 行动点业务CODE，商户自定义
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 行动点展示文案
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// 行动点跳转链接
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
