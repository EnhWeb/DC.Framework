﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdAlipaySecurityProdTestModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdAlipaySecurityProdTestModel : AlipayObject
    {
        /// <summary>
        /// ddd
        /// </summary>
        [JsonProperty("cds")]
        public List<string> Cds { get; set; }

        /// <summary>
        /// aaa
        /// </summary>
        [JsonProperty("ddd")]
        public string Ddd { get; set; }
    }
}
