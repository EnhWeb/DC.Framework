﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertContentShareCode Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertContentShareCode : AlipayObject
    {
        /// <summary>
        /// 吱口令内容详情
        /// </summary>
        [JsonProperty("share_code_desc")]
        public string ShareCodeDesc { get; set; }
    }
}
