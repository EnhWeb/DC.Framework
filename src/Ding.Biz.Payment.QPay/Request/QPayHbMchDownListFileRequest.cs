﻿using System.Collections.Generic;
using Ding.Payment.QPay.Response;
using Ding.Payment.QPay.Utility;

namespace Ding.Payment.QPay.Request
{
    /// <summary>
    /// 现金红包 - 对账单下载
    /// </summary>
    public class QPayHbMchDownListFileRequest : IQPayRequest<QPayHbMchDownListFileResponse>
    {
        /// <summary>
        /// 对账单时间
        /// </summary>
        public string Date { get; set; }

        #region IQPayRequest Members

        public string GetRequestUrl()
        {
            return "https://api.qpay.qq.com/cgi-bin/hongbao/qpay_hb_mch_down_list_file.cgi";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new QPayDictionary
            {
                { "date", Date },
            };
            return parameters;
        }

        public void PrimaryHandler(QPayOptions options, QPayDictionary sortedTxtParams)
        {
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
