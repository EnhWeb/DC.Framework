﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// RepayPlanTermVO Data Structure.
    /// </summary>
    [Serializable]
    public class RepayPlanTermVO : AlipayObject
    {
        /// <summary>
        /// 当期利息
        /// </summary>
        [JsonProperty("int_bal")]
        public string IntBal { get; set; }

        /// <summary>
        /// 当期利息罚息
        /// </summary>
        [JsonProperty("ovd_int_penalty_bal")]
        public string OvdIntPenaltyBal { get; set; }

        /// <summary>
        /// 当期本金罚息
        /// </summary>
        [JsonProperty("ovd_prin_penalty_bal")]
        public string OvdPrinPenaltyBal { get; set; }

        /// <summary>
        /// 当期已还利息
        /// </summary>
        [JsonProperty("paid_int_amt")]
        public string PaidIntAmt { get; set; }

        /// <summary>
        /// 当期已还利息罚息
        /// </summary>
        [JsonProperty("paid_ovd_int_penalty_amt")]
        public string PaidOvdIntPenaltyAmt { get; set; }

        /// <summary>
        /// 当期已还本金罚息
        /// </summary>
        [JsonProperty("paid_ovd_prin_penalty_amt")]
        public string PaidOvdPrinPenaltyAmt { get; set; }

        /// <summary>
        /// 当期已还本金
        /// </summary>
        [JsonProperty("paid_prin_amt")]
        public string PaidPrinAmt { get; set; }

        /// <summary>
        /// 当期本金
        /// </summary>
        [JsonProperty("prin_bal")]
        public string PrinBal { get; set; }

        /// <summary>
        /// 当期应还总额=当期本金+当期利息+当期本金罚息+当期利息罚息
        /// </summary>
        [JsonProperty("repay_amt_total")]
        public string RepayAmtTotal { get; set; }

        /// <summary>
        /// 分期状态，取值{NORMAL, OVD, CLEAR}：NORMAL-正常; OVD-逾期; CLEAR-结清
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 本期到期日，即应还款日期
        /// </summary>
        [JsonProperty("term_end_date")]
        public string TermEndDate { get; set; }

        /// <summary>
        /// 期次号
        /// </summary>
        [JsonProperty("term_no")]
        public long TermNo { get; set; }
    }
}
