﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// BatchRefundDetailResult Data Structure.
    /// </summary>
    [Serializable]
    public class BatchRefundDetailResult : AlipayObject
    {
        /// <summary>
        /// 商户请求批量退款时传递的批次号。
        /// </summary>
        [JsonProperty("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 充退状态：S成功，F失败，P处理中。
        /// </summary>
        [JsonProperty("dback_status")]
        public string DbackStatus { get; set; }

        /// <summary>
        /// 预估银行响应时间
        /// </summary>
        [JsonProperty("est_bank_ack_time")]
        public string EstBankAckTime { get; set; }

        /// <summary>
        /// 预估银行入账时间
        /// </summary>
        [JsonProperty("est_bank_receipt_time")]
        public string EstBankReceiptTime { get; set; }

        /// <summary>
        /// 是否有充退
        /// </summary>
        [JsonProperty("has_deposit_back")]
        public bool HasDepositBack { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [JsonProperty("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款银行名称
        /// </summary>
        [JsonProperty("refund_bank_name")]
        public string RefundBankName { get; set; }

        /// <summary>
        /// 退分润信息列表
        /// </summary>
        [JsonProperty("refund_royaltys")]
        public List<RefundRoyaltyResult> RefundRoyaltys { get; set; }

        /// <summary>
        /// 退补差金额
        /// </summary>
        [JsonProperty("refund_suppl_amount")]
        public string RefundSupplAmount { get; set; }

        /// <summary>
        /// 退补差结果码
        /// </summary>
        [JsonProperty("refund_suppl_result_code")]
        public string RefundSupplResultCode { get; set; }

        /// <summary>
        /// 剩余补差金额
        /// </summary>
        [JsonProperty("rest_suppl_amount")]
        public string RestSupplAmount { get; set; }

        /// <summary>
        /// 交易退款结果码。如果成功为SUCCESS，如果处理中为PROCESSING，其它情况为错误码。
        /// </summary>
        [JsonProperty("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 退款解冻信息
        /// </summary>
        [JsonProperty("unfreeze_details")]
        public RefundUnfreezeResult UnfreezeDetails { get; set; }
    }
}
