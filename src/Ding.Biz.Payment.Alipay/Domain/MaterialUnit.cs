﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// MaterialUnit Data Structure.
    /// </summary>
    [Serializable]
    public class MaterialUnit : AlipayObject
    {
        /// <summary>
        /// 创意元素C端渲染关联位置key值
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// 创意图片/视频物料URL；标题/描述文本值
        /// </summary>
        [JsonProperty("material")]
        public string Material { get; set; }

        /// <summary>
        /// 创意元素类型，IMG-图片；VIDEO-视频；TITLE-标题；DESC-描述
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
