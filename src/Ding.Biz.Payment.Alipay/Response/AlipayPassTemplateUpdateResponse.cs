using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPassTemplateUpdateResponse.
    /// </summary>
    public class AlipayPassTemplateUpdateResponse : AlipayResponse
    {
        /// <summary>
        /// 接口调用返回结果信息(json字串):  errorCode：处理结果码（错误码）；  errorMsg：处理结果说明（错误说明）；  tpl_id：模板编号，预期在调发券接口时必须传入；  tpl_params：动态参数（变量）列表，预期在调发券接口时传入；
        /// </summary>
        [JsonProperty("result")]
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 操作成功标识【true：成功；false：失败】
        /// </summary>
        [JsonProperty("success")]
        [XmlElement("success")]
        public string Success { get; set; }
    }
}