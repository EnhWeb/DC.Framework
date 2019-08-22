﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppSmsgDataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppSmsgDataSyncModel : AlipayObject
    {
        /// <summary>
        /// 10
        /// </summary>
        [JsonProperty("data_one")]
        public string DataOne { get; set; }

        /// <summary>
        /// abc
        /// </summary>
        [JsonProperty("data_two")]
        public string DataTwo { get; set; }
    }
}
