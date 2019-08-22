﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// QRcode Data Structure.
    /// </summary>
    [Serializable]
    public class QRcode : AlipayObject
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// qrcode地址
        /// </summary>
        [JsonProperty("qrcode_url")]
        public string QrcodeUrl { get; set; }
    }
}
