﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// LogisticsExternalInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsExternalInfo : AlipayObject
    {
        /// <summary>
        /// 在CUPBOARD（取餐柜模式 场景），为指定设备编号，单元格编号；  约束定义：  支持批量传入多个单元格编号；  不支持多个设备编号
        /// </summary>
        [JsonProperty("carrier_info_list")]
        public List<LogisticsExternalCarrierInfo> CarrierInfoList { get; set; }

        /// <summary>
        /// 在CUPBOARD（取餐柜模式 场景），为指定单元格数量，系统按照默认规则分配；
        /// </summary>
        [JsonProperty("carrier_sub_count")]
        public long CarrierSubCount { get; set; }
    }
}
