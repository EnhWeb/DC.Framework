﻿using System.Collections.Generic;
using Ding.Payment.WeChatPay.Response;
using Ding.Payment.WeChatPay.Utility;

namespace Ding.Payment.WeChatPay.Request
{
    /// <summary>
    /// 微信代扣 - 车主平台/乘车码代扣 - 查询订单
    /// </summary>
    public class WeChatPayTransitPartnerPayQueryOrderRequest : IWeChatPayRequest<WeChatPayTransitPartnerPayQueryOrderResponse>
    {
        /// <summary>
        /// 子商户应用号
        /// </summary>
        public string SubAppId { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        public string SubMchId { get; set; }

        /// <summary>
        /// 微信订单号
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 委托代扣协议id
        /// </summary>
        public string ContractId { get; set; }

        #region IWeChatPayRequest Members

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/transit/partnerpay/queryorder";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "sub_appid", SubAppId },
                { "sub_mch_id", SubMchId },
                { "transaction_id", TransactionId },
                { "out_trade_no", OutTradeNo },
                { "contract_id", ContractId },
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

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key, signType));
        }

        public bool GetNeedCheckSign()
        {
            return true;
        }

        #endregion
    }
}
