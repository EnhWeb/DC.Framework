﻿using Aliyun.Acs.Core.Utils;
using Ding.Sms.AliYun.Dysmsapi.Transform.V20170525;
using Core = Aliyun.Acs.Core;

namespace Ding.Sms.AliYun.Dysmsapi.Model.V20170525
{
    public class QuerySendDetailsRequest : Core.RpcAcsRequest<QuerySendDetailsResponse>
    {
        public QuerySendDetailsRequest()
            : base("Dysmsapi", "2017-05-25", "QuerySendDetails")
        {
        }

        private string sendDate;

        private long? pageSize;

        private string phoneNumber;

        private string accessKeyId;

        private string resourceOwnerAccount;

        private string action;

        private long? currentPage;

        private string bizId;

        private long? resourceOwnerId;

        private long? ownerId;

        public string SendDate
        {
            get { return sendDate; }
            set
            {
                sendDate = value;
                DictionaryUtil.Add(QueryParameters, "SendDate", value);
            }
        }

        public long? PageSize
        {
            get { return pageSize; }
            set
            {
                pageSize = value;
                DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
            }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                phoneNumber = value;
                DictionaryUtil.Add(QueryParameters, "PhoneNumber", value);
            }
        }

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

        public long? CurrentPage
        {
            get { return currentPage; }
            set
            {
                currentPage = value;
                DictionaryUtil.Add(QueryParameters, "CurrentPage", value.ToString());
            }
        }

        public string BizId
        {
            get { return bizId; }
            set
            {
                bizId = value;
                DictionaryUtil.Add(QueryParameters, "BizId", value);
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

        public override QuerySendDetailsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return QuerySendDetailsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
