﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppCodetesttestModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppCodetesttestModel : AlipayObject
    {
        /// <summary>
        /// 测试参数1
        /// </summary>
        [JsonProperty("testparam")]
        public string Testparam { get; set; }

        /// <summary>
        /// 测试测试
        /// </summary>
        [JsonProperty("testtestparam")]
        public string Testtestparam { get; set; }
    }
}
