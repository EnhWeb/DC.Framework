using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDaoweiOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDaoweiOrderQueryModel : AlipayObject
    {
        /// <summary>
        /// 到位业务订单号。用户在到位下单时，由到位系统生成的32位全局唯一数字 id。  通过应用中的应用网关post发送给商户（应用网关配置参考链接：https%3A%2F%2Fdoc.open.alipay.com%2Fdocs%2Fdoc.htm%3Fspm%3Da219a.7629140.0.0.TcIuKL%26treeId%3D193%26articleId%3D105310%26docType%3D1）。
        /// </summary>
        [JsonProperty("order_no")]
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
