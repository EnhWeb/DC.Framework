﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayHighValueCustomerResult Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayHighValueCustomerResult : AlipayObject
    {
        /// <summary>
        /// Z0-Z7
        /// </summary>
        [JsonProperty("level")]
        public string Level { get; set; }
    }
}
