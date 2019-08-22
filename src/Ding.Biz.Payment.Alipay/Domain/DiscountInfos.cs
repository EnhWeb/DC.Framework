﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// DiscountInfos Data Structure.
    /// </summary>
    [Serializable]
    public class DiscountInfos : AlipayObject
    {
        /// <summary>
        /// 优惠金额
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonProperty("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// 本次支付商家优惠的金额
        /// </summary>
        [JsonProperty("mdiscount_amount")]
        public string MdiscountAmount { get; set; }

        /// <summary>
        /// 优惠名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 本次支付平台补贴的金额
        /// </summary>
        [JsonProperty("platform_discount_amount")]
        public string PlatformDiscountAmount { get; set; }

        /// <summary>
        /// 优惠类型
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
