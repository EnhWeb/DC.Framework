﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicPartnerMenuQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicPartnerMenuQueryModel : AlipayObject
    {
        /// <summary>
        /// 服务窗id
        /// </summary>
        [JsonProperty("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
