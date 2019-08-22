﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeFastpayRefundQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeFastpayRefundQueryModel : AlipayObject
    {
        /// <summary>
        /// 银行间联模式下有用，其它场景请不要使用；  双联通过该参数指定需要查询的交易所属收单机构的pid;
        /// </summary>
        [JsonProperty("org_pid")]
        public string OrgPid { get; set; }

        /// <summary>
        /// 请求退款接口时，传入的退款请求号，如果在退款请求时未传入，则该值为创建交易时的外部交易号
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 订单支付时传入的商户订单号,和支付宝交易号不能同时为空。 trade_no,out_trade_no如果同时存在优先取trade_no
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付宝交易号，和商户订单号不能同时为空
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
