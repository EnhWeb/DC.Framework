﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// Scene Data Structure.
    /// </summary>
    [Serializable]
    public class Scene : AlipayObject
    {
        /// <summary>
        /// 场景Id，最长32位，英文字母、数字以及下划线，开发者自定义
        /// </summary>
        [JsonProperty("scene_id")]
        public string SceneId { get; set; }
    }
}
