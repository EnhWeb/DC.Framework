﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicAdvertCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicAdvertCreateModel : AlipayObject
    {
        /// <summary>
        /// 广告位轮播内容列表，数量限制：大于1个，小于3个，广告位轮播内容顺序，根据接口传入的顺序排列
        /// </summary>
        [JsonProperty("advert_items")]
        public List<AdvertItem> AdvertItems { get; set; }
    }
}
