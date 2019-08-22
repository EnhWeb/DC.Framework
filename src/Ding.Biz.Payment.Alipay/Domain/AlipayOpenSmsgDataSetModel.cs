﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenSmsgDataSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSmsgDataSetModel : AlipayObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [JsonProperty("paramone")]
        public string Paramone { get; set; }

        /// <summary>
        /// 测试参数2
        /// </summary>
        [JsonProperty("paramtwo")]
        public string Paramtwo { get; set; }
    }
}
