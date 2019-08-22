﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// Gavintest Data Structure.
    /// </summary>
    [Serializable]
    public class Gavintest : AlipayObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [JsonProperty("newid")]
        public long Newid { get; set; }
    }
}
