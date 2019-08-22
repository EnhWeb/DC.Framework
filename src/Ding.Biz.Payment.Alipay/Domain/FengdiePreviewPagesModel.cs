﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdiePreviewPagesModel Data Structure.
    /// </summary>
    [Serializable]
    public class FengdiePreviewPagesModel : AlipayObject
    {
        /// <summary>
        /// 站点页面别名
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 页面预览地址
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
