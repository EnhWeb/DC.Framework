﻿using Aliyun.Acs.Core.Utils;
using Ding.Sms.AliYun.Dysmsapi.Transform.V20170525;
using Core = Aliyun.Acs.Core;

namespace Ding.Sms.AliYun.Dysmsapi.Model.V20170525
{
    public class QueryInterSmsIsoInfoRequest : Core.RpcAcsRequest<QueryInterSmsIsoInfoResponse>
    {
        public QueryInterSmsIsoInfoRequest()
            : base("Dysmsapi", "2017-05-25", "QueryInterSmsIsoInfo")
        {
        }

        private string accessKeyId;

        private string resourceOwnerAccount;

        private string action;

        private string countryName;

        private long? resourceOwnerId;

        private long? ownerId;

        public string AccessKeyId
        {
            get { return accessKeyId; }
            set
            {
                accessKeyId = value;
                DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
            }
        }

        public string ResourceOwnerAccount
        {
            get { return resourceOwnerAccount; }
            set
            {
                resourceOwnerAccount = value;
                DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
            }
        }

        public string Action
        {
            get { return action; }
            set
            {
                action = value;
                DictionaryUtil.Add(QueryParameters, "Action", value);
            }
        }

        public string CountryName
        {
            get { return countryName; }
            set
            {
                countryName = value;
                DictionaryUtil.Add(QueryParameters, "CountryName", value);
            }
        }

        public long? ResourceOwnerId
        {
            get { return resourceOwnerId; }
            set
            {
                resourceOwnerId = value;
                DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
            }
        }

        public long? OwnerId
        {
            get { return ownerId; }
            set
            {
                ownerId = value;
                DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
            }
        }

        public override QueryInterSmsIsoInfoResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return QueryInterSmsIsoInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
