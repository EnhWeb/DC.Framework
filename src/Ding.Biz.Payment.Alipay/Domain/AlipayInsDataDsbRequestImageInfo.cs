﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsDataDsbRequestImageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsDataDsbRequestImageInfo : AlipayObject
    {
        /// <summary>
        /// 图像文件名称
        /// </summary>
        [JsonProperty("image_name")]
        public string ImageName { get; set; }

        /// <summary>
        /// 图像文件在存储上的路径
        /// </summary>
        [JsonProperty("image_path")]
        public string ImagePath { get; set; }
    }
}
