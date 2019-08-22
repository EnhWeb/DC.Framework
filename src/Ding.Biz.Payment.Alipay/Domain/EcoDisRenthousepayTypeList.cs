﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// EcoDisRenthousepayTypeList Data Structure.
    /// </summary>
    [Serializable]
    public class EcoDisRenthousepayTypeList : AlipayObject
    {
        /// <summary>
        /// 押金
        /// </summary>
        [JsonProperty("foregift_amount")]
        public string ForegiftAmount { get; set; }

        /// <summary>
        /// 可租期（1：1个月，3：三个月，6：半年，12：一年及以上）
        /// </summary>
        [JsonProperty("lease_term")]
        public long LeaseTerm { get; set; }

        /// <summary>
        /// 其他费用
        /// </summary>
        [JsonProperty("other_amount")]
        public List<EcoRenthouseOtherAmount> OtherAmount { get; set; }

        /// <summary>
        /// 付款方式（1：付一，2：付二）
        /// </summary>
        [JsonProperty("pay_type")]
        public long PayType { get; set; }

        /// <summary>
        /// 租金
        /// </summary>
        [JsonProperty("room_amount")]
        public string RoomAmount { get; set; }

        /// <summary>
        /// 服务费
        /// </summary>
        [JsonProperty("service_amount")]
        public string ServiceAmount { get; set; }

        /// <summary>
        /// 服务费单位（m：月, y：年）
        /// </summary>
        [JsonProperty("service_type")]
        public string ServiceType { get; set; }
    }
}
