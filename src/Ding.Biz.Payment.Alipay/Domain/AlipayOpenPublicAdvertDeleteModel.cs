﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicAdvertDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicAdvertDeleteModel : AlipayObject
    {
        /// <summary>
        /// 待删除的广告位id
        /// </summary>
        [JsonProperty("advert_id")]
        public string AdvertId { get; set; }
    }
}
