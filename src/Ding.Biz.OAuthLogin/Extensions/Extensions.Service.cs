﻿using Ding.Biz.OAuthLogin.QQ.Configs;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using Ding.Biz.OAuthLogin.WeChat.Configs;
using Ding.Biz.OAuthLogin.GitHub.Configs;
using Ding.Biz.OAuthLogin.Taobao.Configs;
using Ding.Biz.OAuthLogin.MicroSoft.Configs;
using Ding.Biz.OAuthLogin.Weibo.Configs;

namespace Ding.Biz.OAuthLogin.Extensions
{
    /// <summary>
    /// 登录扩展
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        /// 注册登录操作
        /// </summary>
        /// <param name="services">服务集合</param>
        /// <param name="setupAction">配置操作</param>
        public static void AddLogin(this IServiceCollection services, Action<LoginOptions> setupAction)
        {
            var options = new LoginOptions();
            setupAction?.Invoke(options);
            services.TryAddSingleton<IQQConfigProvider>(new QQConfigProvider(options.QqOptions));
            services.TryAddSingleton<IWeChatConfigProvider>(new WeChatConfigProvider(options.WeChatOptions));
            services.TryAddSingleton<IGitHubConfigProvider>(new GitHubConfigProvider(options.GitHubOptions));
            services.TryAddSingleton<IMicroSoftConfigProvider>(new MicroSoftConfigProvider(options.MicroSoftConfig));
            services.TryAddSingleton<ITaobaoConfigProvider>(new TaobaoConfigProvider(options.TaobaoConfig));
            services.TryAddSingleton<IWeiboConfigProvider>(new WeiboConfigProvider(options.WeiboConfig));
            services.TryAddScoped<ILoginFactory, LoginFactory>();
        }
    }
}
