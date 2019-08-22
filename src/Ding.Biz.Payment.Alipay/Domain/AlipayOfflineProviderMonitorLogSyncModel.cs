﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOfflineProviderMonitorLogSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderMonitorLogSyncModel : AlipayObject
    {
        /// <summary>
        /// 数据回流日志
        /// </summary>
        [JsonProperty("logs")]
        public List<ISVLogSync> Logs { get; set; }
    }
}
