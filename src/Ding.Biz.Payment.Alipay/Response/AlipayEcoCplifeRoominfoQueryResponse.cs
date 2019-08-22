﻿using System.Collections.Generic;
using Ding.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoCplifeRoominfoQueryResponse.
    /// </summary>
    public class AlipayEcoCplifeRoominfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 符合条件的小区房屋信息列表.
        /// </summary>
        [JsonProperty("room_info")]
        public List<CplifeRoomDetail> RoomInfo { get; set; }

        /// <summary>
        /// 该小区下已上传的房间总数
        /// </summary>
        [JsonProperty("total_room_number")]
        public long TotalRoomNumber { get; set; }
    }
}
