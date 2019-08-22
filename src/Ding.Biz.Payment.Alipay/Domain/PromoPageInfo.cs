﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// PromoPageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PromoPageInfo : AlipayObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }
    }
}
