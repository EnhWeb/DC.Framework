using System.Collections.Generic;
using System.Xml.Serialization;
using Ding.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCardTemplateBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingCardTemplateBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 会员卡模板基本信息
        /// </summary>
        [JsonProperty("mcard_template")]
        [XmlArray("mcard_template")]
        [XmlArrayItem("mcard_template")]
        public List<McardTemplate> McardTemplate { get; set; }

        /// <summary>
        /// 会员卡模板总数
        /// </summary>
        [JsonProperty("template_total")]
        [XmlElement("template_total")]
        public long TemplateTotal { get; set; }
    }
}
