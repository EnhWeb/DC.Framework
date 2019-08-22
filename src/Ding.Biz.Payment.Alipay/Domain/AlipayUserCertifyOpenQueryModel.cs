﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCertifyOpenQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCertifyOpenQueryModel : AlipayObject
    {
        /// <summary>
        /// 本次申请操作的唯一标识，由开放认证初始化接口调用后生成，后续的操作都需要用到
        /// </summary>
        [JsonProperty("certify_id")]
        public string CertifyId { get; set; }
    }
}
