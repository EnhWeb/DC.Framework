using System.Xml.Serialization;
using Ding.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayZmscoreZrankGetResponse.
    /// </summary>
    public class AlipayZmscoreZrankGetResponse : AlipayResponse
    {
        /// <summary>
        /// 芝麻分分段
        /// </summary>
        [JsonProperty("zm_score_zrank")]
        [XmlElement("zm_score_zrank")]
        public AlipayZmScoreZrankResult ZmScoreZrank { get; set; }
    }
}
