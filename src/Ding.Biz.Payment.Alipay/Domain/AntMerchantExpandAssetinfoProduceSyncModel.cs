﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ding.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetinfoProduceSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetinfoProduceSyncModel : AlipayObject
    {
        /// <summary>
        /// 传入需要反馈的物料信息对象列表。
        /// </summary>
        [JsonProperty("asset_infos")]
        public List<AssetInfoItem> AssetInfos { get; set; }
    }
}
