﻿using Ding.Biz.OAuthLogin.GitHub.Configs;
using Ding.Extension;
using Ding.Helpers;
using System;

namespace Ding.Biz.OAuthLogin
{
    /// <summary>
    /// Step1：获取authorize Code
    /// </summary>
    public class GitHub_Authorize_RequestEntity
    {
        /// <summary>
        /// GitHub登录配置
        /// </summary>
        protected static readonly GitHubConfig GitHubConfig;

        /// <summary>
        /// 初始化一个<see cref="GitHub_Authorize_RequestEntity"/>类型的实例
        /// </summary>
        static GitHub_Authorize_RequestEntity()
        {
            var provider = Ioc.Create<IGitHubConfigProvider>();
            provider.CheckNotNull(nameof(provider));
            GitHubConfig = provider.GetConfigAsync().Result;
        }

        /// <summary>
        /// 注册应用时的获取的client_id
        /// </summary>
        [Required]
        public string client_id { get; set; } = GitHubConfig.APPID;
        /// <summary>
        /// github鉴权成功之后，重定向到网站
        /// </summary>
        [Required]
        public string redirect_uri { get; set; } = GitHubConfig.Redirect_Uri;
        /// <summary>
        /// 自己设定，用于防止跨站请求伪造攻击
        /// </summary>
        [Required]
        public string state { get; set; } = Guid.NewGuid().ToString("N");

        /// <summary>
        /// 该参数可选。需要调用Github哪些信息，可以填写多个，以逗号分割，比如：scope=user public_repo。
        /// 如果不填写，那么你的应用程序将只能读取Github公开的信息，比如公开的用户信息，公开的库(repository)信息以及gists信息
        /// </summary>
        public string scope { get; set; } = "user,public_repo";

        /// <summary>
        /// 
        /// </summary>
        public string allow_signup { get; set; }
    }
}
