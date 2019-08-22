﻿using System.Collections.Generic;
using Ding.Payment.QPay.Response;
using Ding.Payment.QPay.Utility;

namespace Ding.Payment.QPay.Request
{
    /// <summary>
    /// 企业付款 - 对账单下载
    /// </summary>
    public class QPayEPayStatementDownRequest : IQPayRequest<QPayEPayStatementDownResponse>
    {
        /// <summary>
        /// 对账单时间
        /// </summary>
        public string BillDate { get; set; }

        #region IQPayRequest Members

        public string GetRequestUrl()
        {
            return "https://qpay.qq.com/cgi-bin/pay/qpay_epay_statement_down.cgi";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new QPayDictionary
            {
                { "bill_date", BillDate },
            };
            return parameters;
        }

        public void PrimaryHandler(QPayOptions options, QPayDictionary sortedTxtParams)
        {
            sortedTxtParams.Add(QPayConsts.NONCE_STR, QPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(QPayConsts.MCH_ID, options.MchId);

            sortedTxtParams.Add(QPayConsts.SIGN, QPaySignature.SignWithKey(sortedTxtParams, options.Key));
        }

        public bool GetNeedCheckSign()
        {
            return false;
        }

        #endregion
    }
}
