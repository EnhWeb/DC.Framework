﻿using System.Threading.Tasks;

namespace Ding.Payment.Alipay
{
    public interface IAlipayClient
    {
        /// <summary>
        /// 执行 Alipay API请求。
        /// </summary>
        /// <param name="request">具体的Alipay API请求</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options) where T : AlipayResponse;

        /// <summary>
        /// 执行 Alipay API请求。
        /// </summary>
        /// <param name="request">具体的Alipay API请求</param>
        /// <param name="options">配置选项</param>
        /// <param name="accessToken">用户会话码</param>
        /// <param name="appAuthToken">应用授权码</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string accessToken, string appAuthToken) where T : AlipayResponse;

        /// <summary>
        /// 执行 Alipay API请求。
        /// </summary>
        /// <param name="request">具体的Alipay API请求</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> PageExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options) where T : AlipayResponse;

        /// <summary>
        /// 执行 Alipay API请求。
        /// </summary>
        /// <param name="request">具体的Alipay API请求</param>
        /// <param name="options">配置选项</param>
        /// <param name="accessToken">用户会话码</param>
        /// <param name="reqMethod">请求访问方法</param>
        /// <returns>领域对象</returns>
        Task<T> PageExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string accessToken, string reqMethod) where T : AlipayResponse;

        /// <summary>
        /// 执行 Alipay API请求。
        /// </summary>
        /// <param name="request">具体的Alipay API请求</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> SdkExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options) where T : AlipayResponse;
    }
}
