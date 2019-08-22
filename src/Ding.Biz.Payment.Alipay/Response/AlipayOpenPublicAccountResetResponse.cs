﻿using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicAccountResetResponse.
    /// </summary>
    public class AlipayOpenPublicAccountResetResponse : AlipayResponse
    {
        /// <summary>
        /// 重置后的协议号，商户会员在支付宝服务窗账号中的唯一标识
        /// </summary>
        [JsonProperty("agreement_id")]
        public string AgreementId { get; set; }
    }
}
