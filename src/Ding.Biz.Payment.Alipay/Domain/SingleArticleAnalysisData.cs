﻿using System;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// SingleArticleAnalysisData Data Structure.
    /// </summary>
    [Serializable]
    public class SingleArticleAnalysisData : AlipayObject
    {
        /// <summary>
        /// 人均阅读时长
        /// </summary>
        [JsonProperty("avg_read_time")]
        public string AvgReadTime { get; set; }

        /// <summary>
        /// 文章发布日期
        /// </summary>
        [JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>
        /// 送达人数
        /// </summary>
        [JsonProperty("deliver_user_cnt")]
        public long DeliverUserCnt { get; set; }

        /// <summary>
        /// 曝光人数
        /// </summary>
        [JsonProperty("expose_user_cnt")]
        public long ExposeUserCnt { get; set; }

        /// <summary>
        /// 点赞数
        /// </summary>
        [JsonProperty("praise_user_cnt")]
        public long PraiseUserCnt { get; set; }

        /// <summary>
        /// 阅读人数
        /// </summary>
        [JsonProperty("read_user_cnt")]
        public long ReadUserCnt { get; set; }

        /// <summary>
        /// 评论数
        /// </summary>
        [JsonProperty("reply_user_cnt")]
        public long ReplyUserCnt { get; set; }

        /// <summary>
        /// 分享人数
        /// </summary>
        [JsonProperty("share_user_cnt")]
        public long ShareUserCnt { get; set; }

        /// <summary>
        /// 文章标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
