﻿using System.Collections.Generic;
using Ding.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodEnquriyApplyResponse.
    /// </summary>
    public class AlipayInsAutoAutoinsprodEnquriyApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 车辆的品牌型号列表
        /// </summary>
        [JsonProperty("car_model")]
        public List<CarModel> CarModel { get; set; }

        /// <summary>
        /// 车险询价申请号
        /// </summary>
        [JsonProperty("enquiry_biz_id")]
        public string EnquiryBizId { get; set; }

        /// <summary>
        /// 外部询价申请业务单号（幂等字段）
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
