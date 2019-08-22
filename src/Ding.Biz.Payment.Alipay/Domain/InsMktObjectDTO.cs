﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// InsMktObjectDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsMktObjectDTO : AlipayObject
    {
        /// <summary>
        /// 活动标的id
        /// </summary>
        [JsonProperty("obj_id")]
        public string ObjId { get; set; }

        /// <summary>
        /// 标的类型
        /// </summary>
        [JsonProperty("type")]
        public long Type { get; set; }
    }
}
