using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAssetPointAccountlogQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAssetPointAccountlogQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户流水查询起始时间
        /// </summary>
        [JsonProperty("account_date_begin")]
        [XmlElement("account_date_begin")]
        public string AccountDateBegin { get; set; }

        /// <summary>
        /// 用户流水查询结束时间
        /// </summary>
        [JsonProperty("account_date_end")]
        [XmlElement("account_date_end")]
        public string AccountDateEnd { get; set; }

        /// <summary>
        /// 分页查询的当前页号,从1开始
        /// </summary>
        [JsonProperty("page_number")]
        [XmlElement("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 分页查询的单页大小
        /// </summary>
        [JsonProperty("page_size")]
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 子交易代码，标记大业务下的子业务，例如充值－外部商户发放，可选参数可以不传
        /// </summary>
        [JsonProperty("sub_trans_code")]
        [XmlArray("sub_trans_code")]
        [XmlArrayItem("string")]
        public List<string> SubTransCode { get; set; }

        /// <summary>
        /// 主交易代码,例如支付、充值等，标记业务大类，可选参数可以不传
        /// </summary>
        [JsonProperty("trans_code")]
        [XmlArray("trans_code")]
        [XmlArrayItem("string")]
        public List<string> TransCode { get; set; }

        /// <summary>
        /// 用户标识符，用于指定集分宝发放的用户，和user_symbol_type一起使用，确定一个唯一的支付宝用户
        /// </summary>
        [JsonProperty("user_symbol")]
        [XmlElement("user_symbol")]
        public string UserSymbol { get; set; }

        /// <summary>
        /// 用户标识符类型，  现在支持ALIPAY_USER_ID:表示支付宝用户ID,  ALIPAY_LOGON_ID:表示支付宝登陆号,
        /// </summary>
        [JsonProperty("user_symbol_type")]
        [XmlElement("user_symbol_type")]
        public string UserSymbolType { get; set; }
    }
}