﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// InsMerchant Data Structure.
    /// </summary>
    [Serializable]
    public class InsMerchant : AlipayObject
    {
        /// <summary>
        /// 机构全称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务电话
        /// </summary>
        [JsonProperty("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 机构简称
        /// </summary>
        [JsonProperty("short_name")]
        public string ShortName { get; set; }
    }
}
