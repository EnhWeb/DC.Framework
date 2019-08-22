﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// KbPosBillDishDetail Data Structure.
    /// </summary>
    [Serializable]
    public class KbPosBillDishDetail : AlipayObject
    {
        /// <summary>
        /// pos本地订单菜明细流水号
        /// </summary>
        [JsonProperty("out_detail_no")]
        public string OutDetailNo { get; set; }

        /// <summary>
        /// 优免分摊金额（包含内部和外部优惠），以元为单位，精度到分
        /// </summary>
        [JsonProperty("trans_amount")]
        public string TransAmount { get; set; }
    }
}
