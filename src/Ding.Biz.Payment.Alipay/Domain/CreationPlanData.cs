﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// CreationPlanData Data Structure.
    /// </summary>
    [Serializable]
    public class CreationPlanData : AlipayObject
    {
        /// <summary>
        /// 定向的设备sn列表
        /// </summary>
        [JsonProperty("device_sn_list")]
        public List<string> DeviceSnList { get; set; }

        /// <summary>
        /// 投放结束时间
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 额外信息
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 投放计划id
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// 投放的物料地址
        /// </summary>
        [JsonProperty("material_url")]
        public string MaterialUrl { get; set; }

        /// <summary>
        /// 投放计划名称
        /// </summary>
        [JsonProperty("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 投放开始时间
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 投放计划状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
