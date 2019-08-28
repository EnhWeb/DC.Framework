﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionOfflinePublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionOfflinePublishModel : AlipayObject
    {
        /// <summary>
        /// 业务来源
        /// </summary>
        [JsonProperty("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端信息
        /// </summary>
        [JsonProperty("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序所属PID
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }
    }
}
