﻿using Ding.Biz.OAuthLogin.Taobao.Configs;
using Ding.Extension;
using Ding.Helpers;

namespace Ding.Biz.OAuthLogin
{
    /// <summary>
    /// Step2：Oauth2/access token
    /// </summary>
    public class Taobao_AccessToken_RequestEntity
    {
        /// <summary>
        /// Taobao登录配置
        /// </summary>
        protected static readonly TaobaoConfig TaobaoConfig;

        /// <summary>
        /// 初始化一个<see cref="Taobao_AccessToken_RequestEntity"/>类型的实例
        /// </summary>
        static Taobao_AccessToken_RequestEntity()
        {
            var provider = Ioc.Create<ITaobaoConfigProvider>();
            provider.CheckNotNull(nameof(provider));
            TaobaoConfig = provider.GetConfigAsync().Result;
        }

        /// <summary>
        /// 等同于AppKey，创建应用时获得。
        /// </summary>
        [Required]
        public string client_id { get; set; } = TaobaoConfig.APPID;

        /// <summary>
        /// 等同于AppSecret，创建应用时获得。
        /// </summary>
        [Required]
        public string client_secret { get; set; } = TaobaoConfig.APPKey;

        /// <summary>
        /// authorization_code	授权类型 ，值为authorization_code
        /// </summary>
        [Required]
        public string grant_type { get; set; } = "authorization_code";

        /// <summary>
        /// 上一步获取code得到
        /// </summary>
        [Required]
        public string code { get; set; }

        /// <summary>
        /// 可填写应用注册时回调地址域名。
        /// redirect_uri指的是应用发起请求时，所传的回调地址参数，在用户授权后应用会跳转至redirect_uri。
        /// 要求与应用注册时填写的回调地址域名一致或顶级域名一致 。
        /// </summary>
        [Required]
        public string redirect_uri { get; set; } = TaobaoConfig.Redirect_Uri;

        /// <summary>
        /// 可自定义，如1212等；维持应用的状态，传入值与返回值保持一致。
        /// </summary>
        public string state { get; set; } = System.Guid.NewGuid().ToString("N");

        /// <summary>
        /// 可选web、tmall或wap其中一种，
        /// Web对应PC端（淘宝logo）浏览器页面样式；
        /// Tmall对应天猫的浏览器页面样式；
        /// Wap对应无线端的浏览器页面样式。
        /// </summary>
        public string view { get; set; } = "web";

    }
}
