﻿using System.Collections.Generic;
using Ding.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingToolIsvMerchantQueryResponse.
    /// </summary>
    public class KoubeiMarketingToolIsvMerchantQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商户信息列表
        /// </summary>
        [JsonProperty("merchant_infos")]
        public List<IsvMerchantInfo> MerchantInfos { get; set; }

        /// <summary>
        /// 门店总量
        /// </summary>
        [JsonProperty("shop_count")]
        public string ShopCount { get; set; }

        /// <summary>
        /// 门店详情列表信息
        /// </summary>
        [JsonProperty("shop_summary_infos")]
        public List<ShopSummaryInfo> ShopSummaryInfos { get; set; }
    }
}
