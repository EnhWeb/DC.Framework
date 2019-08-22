﻿using System.Collections.Generic;
using Ding.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataCustomreportQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 数据量
        /// </summary>
        [JsonProperty("count")]
        public string Count { get; set; }

        /// <summary>
        /// 满足自定义报表规则的报表数据
        /// </summary>
        [JsonProperty("report_data")]
        public List<ReportDataItem> ReportData { get; set; }
    }
}
