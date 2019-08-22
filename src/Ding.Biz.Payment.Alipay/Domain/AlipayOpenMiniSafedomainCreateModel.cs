﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniSafedomainCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniSafedomainCreateModel : AlipayObject
    {
        /// <summary>
        /// httpRequest域白名单
        /// </summary>
        [JsonProperty("safe_domain")]
        public string SafeDomain { get; set; }
    }
}
