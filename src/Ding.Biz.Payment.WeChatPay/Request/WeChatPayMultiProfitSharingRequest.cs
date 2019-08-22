﻿using System.Collections.Generic;
using Ding.Payment.WeChatPay.Response;
using Ding.Payment.WeChatPay.Utility;

namespace Ding.Payment.WeChatPay.Request
{
    /// <summary>
    /// 多次分账
    /// </summary>
    public class WeChatPayMultiProfitSharingRequest : IWeChatPayCertRequest<WeChatPayMultiProfitSharingResponse>
    {
        /// <summary>
        /// 子商户号
        /// </summary>
        public string SubMchId { get; set; }

        /// <summary>
        /// 子商户应用号
        /// </summary>
        public string SubAppId { get; set; }

        /// <summary>
        /// 微信订单号
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// 商户分账单号
        /// </summary>
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 分账接收方列表
        /// </summary>
        public string Receivers { get; set; }

        #region IWeChatPayCertificateRequest Members

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/secapi/pay/multiprofitsharing";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "sub_mch_id", SubMchId },
                { "sub_appid", SubAppId },
                { "transaction_id", TransactionId },
                { "out_order_no", OutOrderNo },
                { "receivers", Receivers },
            };
            return parameters;
        }

        public WeChatPaySignType GetSignType()
        {
            return WeChatPaySignType.HMAC_SHA256;
        }

        public void PrimaryHandler(WeChatPayOptions options, WeChatPaySignType signType, WeChatPayDictionary sortedTxtParams)
        {
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);

            if (signType == WeChatPaySignType.HMAC_SHA256)
            {
                sortedTxtParams.Add(WeChatPayConsts.sign_type, WeChatPayConsts.HMAC_SHA256);
            }
        }

        public bool GetNeedCheckSign()
        {
            return true;
        }

        #endregion
    }
}
