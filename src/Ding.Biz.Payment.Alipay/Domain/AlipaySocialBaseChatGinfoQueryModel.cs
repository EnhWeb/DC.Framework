﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseChatGinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseChatGinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 群id
        /// </summary>
        [JsonProperty("group_id")]
        public string GroupId { get; set; }
    }
}
