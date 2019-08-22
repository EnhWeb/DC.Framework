﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// ParkingScene Data Structure.
    /// </summary>
    [Serializable]
    public class ParkingScene : AlipayObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonProperty("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 车辆入场的时间，格式"YYYY-MM-DD HH:mm:ss"，24小时制
        /// </summary>
        [JsonProperty("in_time")]
        public string InTime { get; set; }

        /// <summary>
        /// 停车场ID
        /// </summary>
        [JsonProperty("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 停车场名称
        /// </summary>
        [JsonProperty("parking_name")]
        public string ParkingName { get; set; }
    }
}
