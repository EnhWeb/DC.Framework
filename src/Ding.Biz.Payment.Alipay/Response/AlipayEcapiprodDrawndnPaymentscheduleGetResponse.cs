﻿using System.Collections.Generic;
using Ding.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcapiprodDrawndnPaymentscheduleGetResponse.
    /// </summary>
    public class AlipayEcapiprodDrawndnPaymentscheduleGetResponse : AlipayResponse
    {
        /// <summary>
        /// 返回的支用还款计划集合
        /// </summary>
        [JsonProperty("payment_schedules")]
        public List<PaymentSchedule> PaymentSchedules { get; set; }

        /// <summary>
        /// 唯一标识这次请求
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }
}
