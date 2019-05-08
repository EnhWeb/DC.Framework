using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// Filter Data Structure.
    /// </summary>
    [Serializable]
    public class Filter : AlipayObject
    {
        /// <summary>
        /// 标签组发圈人条件
        /// </summary>
        [JsonProperty("context")]
        [XmlElement("context")]
        public LabelContext Context { get; set; }

        /// <summary>
        /// 过滤器模板，${a}是一个变量，会被context参数中的a参数替换，从而展开为最终的表达式，template最多支持两个参数，支持and及or连接符。  and：同时满足条件；  or：只需满足其中一个条件
        /// </summary>
        [JsonProperty("template")]
        [XmlElement("template")]
        public string Template { get; set; }
    }
}