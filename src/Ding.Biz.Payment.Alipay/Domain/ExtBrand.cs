﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// ExtBrand Data Structure.
    /// </summary>
    [Serializable]
    public class ExtBrand : AlipayObject
    {
        /// <summary>
        /// 品牌编码
        /// </summary>
        [JsonProperty("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
