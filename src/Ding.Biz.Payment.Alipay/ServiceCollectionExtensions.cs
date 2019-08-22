﻿using System;
using Microsoft.Extensions.DependencyInjection;

namespace Ding.Payment.Alipay
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAlipay(
            this IServiceCollection services)
        {
            services.AddAlipay(null);
        }

        public static void AddAlipay(
            this IServiceCollection services,
            Action<AlipayOptions> setupAction)
        {
            services.AddHttpClient(nameof(AlipayClient));

            services.AddSingleton<IAlipayClient, AlipayClient>();
            services.AddSingleton<IAlipayNotifyClient, AlipayNotifyClient>();

            if (setupAction != null)
            {
                services.Configure(setupAction);
            }
        }
    }
}