using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantOrderRentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantOrderRentQueryModel : AlipayObject
    {
        /// <summary>
        /// 外部订单号，需要唯一，由商户传入，芝麻内部会做幂等控制，格式为：yyyyMMddHHmmss+随机数
        /// </summary>
        [JsonProperty("out_order_no")]
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 信用借还的产品码:w1010100000000002858
        /// </summary>
        [JsonProperty("product_code")]
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
