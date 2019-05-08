using System.Xml.Serialization;
using Ding.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieTemplateSendResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieTemplateSendResponse : AlipayResponse
    {
        /// <summary>
        /// 分配模板的操作是否成功
        /// </summary>
        [JsonProperty("data")]
        [XmlElement("data")]
        public FengdieSuccessRespModel Data { get; set; }
    }
}