﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// QueryInstBillDetail Data Structure.
    /// </summary>
    [Serializable]
    public class QueryInstBillDetail : AlipayObject
    {
        /// <summary>
        /// 明细key
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// 明细描述
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 明细对应值
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
