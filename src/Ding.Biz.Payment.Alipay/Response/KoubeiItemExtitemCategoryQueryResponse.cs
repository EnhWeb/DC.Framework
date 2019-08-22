﻿using System.Collections.Generic;
using Ding.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiItemExtitemCategoryQueryResponse.
    /// </summary>
    public class KoubeiItemExtitemCategoryQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 品类信息列表
        /// </summary>
        [JsonProperty("category_list")]
        public List<ExtCategory> CategoryList { get; set; }
    }
}
