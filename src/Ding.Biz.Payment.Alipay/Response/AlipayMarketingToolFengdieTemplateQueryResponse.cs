using System.Collections.Generic;
using System.Xml.Serialization;
using Ding.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieTemplateQueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieTemplateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 开发者开发上传的H5模板列表
        /// </summary>
        [JsonProperty("template")]
        [XmlArray("template")]
        [XmlArrayItem("fengdie_template")]
        public List<FengdieTemplate> Template { get; set; }
    }
}
