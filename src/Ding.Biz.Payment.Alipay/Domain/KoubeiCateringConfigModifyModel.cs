﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringConfigModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringConfigModifyModel : AlipayObject
    {
        /// <summary>
        /// 外部请求ID; 标识ISV本次修改的请求，由开发者自定义，不同的请求使用不同的ID，在门店notify消息中也会带有该参数，以此标明本次notify消息是对哪个请求的回应
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 店铺配置信息列表
        /// </summary>
        [JsonProperty("shop_config_list")]
        public List<ShopOrderConfigInfo> ShopConfigList { get; set; }
    }
}