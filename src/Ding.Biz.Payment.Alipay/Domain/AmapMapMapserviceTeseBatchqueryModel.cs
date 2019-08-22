﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AmapMapMapserviceTeseBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AmapMapMapserviceTeseBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 2
        /// </summary>
        [JsonProperty("sed")]
        public string Sed { get; set; }
    }
}
