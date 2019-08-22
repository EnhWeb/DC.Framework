﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicMessageLabelSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicMessageLabelSendModel : AlipayObject
    {
        /// <summary>
        /// 根据标签圈人的过滤器
        /// </summary>
        [JsonProperty("filter")]
        public Filter Filter { get; set; }

        /// <summary>
        /// 发送消息内容，支持文本消息和图文消息
        /// </summary>
        [JsonProperty("material")]
        public Material Material { get; set; }
    }
}
