﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingChargeinfoSyncResponse.
    /// </summary>
    public class AlipayEcoMycarParkingChargeinfoSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 同步结果：0 成功，1 失败
        /// </summary>
        [JsonProperty("sync_result")]
        public string SyncResult { get; set; }
    }
}
