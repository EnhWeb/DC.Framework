﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayKeyanClass Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayKeyanClass : AlipayObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }
    }
}
