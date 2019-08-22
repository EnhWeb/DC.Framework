﻿using System.Collections.Generic;
using Ding.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// MybankFinanceYulibaoPriceQueryResponse.
    /// </summary>
    public class MybankFinanceYulibaoPriceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 余利宝行情信息列表
        /// </summary>
        [JsonProperty("ylb_price_detail_infos")]
        public List<YLBPriceDetailInfo> YlbPriceDetailInfos { get; set; }
    }
}
