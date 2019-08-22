﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorFunctionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorFunctionQueryModel : AlipayObject
    {
        /// <summary>
        /// 城市国家标准编码
        /// </summary>
        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 终端设备编码，android可直接获取设备的devicecode值
        /// </summary>
        [JsonProperty("device_code")]
        public string DeviceCode { get; set; }
    }
}
