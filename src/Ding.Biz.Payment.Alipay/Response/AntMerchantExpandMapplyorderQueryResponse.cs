﻿using System.Collections.Generic;
using Ding.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandMapplyorderQueryResponse.
    /// </summary>
    public class AntMerchantExpandMapplyorderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝端商户入驻申请单据号
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付宝商户入驻申请单状态
        /// </summary>
        [JsonProperty("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 外部入驻申请单据号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 入驻申请单认证审核、签约审核详情
        /// </summary>
        [JsonProperty("result_info")]
        public List<MerchantApplyResultRecord> ResultInfo { get; set; }
    }
}
