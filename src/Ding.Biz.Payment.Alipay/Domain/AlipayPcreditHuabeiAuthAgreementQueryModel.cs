﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiAuthAgreementQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiAuthAgreementQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号，即花呗先享协议号。传入该参数，会忽略其它所有参数。
        /// </summary>
        [JsonProperty("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        [JsonProperty("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 花呗先享签约场景，商户和支付宝签约时确定。该值需要与系统/页面签约接口调用时传入的值保持一致。
        /// </summary>
        [JsonProperty("auth_scene")]
        public string AuthScene { get; set; }

        /// <summary>
        /// 外部签约号，由商户提供，花呗先享协议中标识用户的唯一签约号（确保在商户系统中唯一）。
        /// </summary>
        [JsonProperty("out_sign_no")]
        public string OutSignNo { get; set; }
    }
}