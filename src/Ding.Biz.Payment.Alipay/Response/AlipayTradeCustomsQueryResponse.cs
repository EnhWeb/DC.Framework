using System.Collections.Generic;
using System.Xml.Serialization;
using Ding.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeCustomsQueryResponse.
    /// </summary>
    public class AlipayTradeCustomsQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 不存在记录的报关请求号。多个值用逗号分隔，单次最多10个;每个报关请求号String(32)
        /// </summary>
        [JsonProperty("not_found")]
        [XmlElement("not_found")]
        public string NotFound { get; set; }

        /// <summary>
        /// 匹配到的列表。每个记录代表一条报关记录
        /// </summary>
        [JsonProperty("records")]
        [XmlArray("records")]
        [XmlArrayItem("customs_declare_record_info")]
        public List<CustomsDeclareRecordInfo> Records { get; set; }
    }
}