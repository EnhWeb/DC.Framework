using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingToolFengdieSitesBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 作为当前操作者的空间成员用户名， 值为 origin_user_id（即创建空间成员接口的入参）
        /// </summary>
        [JsonProperty("operator")]
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 当前页数，默认为1
        /// </summary>
        [JsonProperty("page_number")]
        [XmlElement("page_number")]
        public string PageNumber { get; set; }

        /// <summary>
        /// 每页记录数，不能超过50，默认为10
        /// </summary>
        [JsonProperty("page_size")]
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 欲查询的云凤蝶业务空间 ID
        /// </summary>
        [JsonProperty("space_id")]
        [XmlElement("space_id")]
        public string SpaceId { get; set; }
    }
}
