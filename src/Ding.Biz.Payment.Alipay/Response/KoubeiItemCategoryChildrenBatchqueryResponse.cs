﻿using System.Collections.Generic;
using Ding.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiItemCategoryChildrenBatchqueryResponse.
    /// </summary>
    public class KoubeiItemCategoryChildrenBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑标准后台类目信息列表
        /// </summary>
        [JsonProperty("category_list")]
        public List<StandardCategoryInfo> CategoryList { get; set; }
    }
}
