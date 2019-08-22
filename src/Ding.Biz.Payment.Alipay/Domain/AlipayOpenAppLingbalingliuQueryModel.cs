﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppLingbalingliuQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppLingbalingliuQueryModel : AlipayObject
    {
        /// <summary>
        /// 12
        /// </summary>
        [JsonProperty("canshu")]
        public string Canshu { get; set; }
    }
}
