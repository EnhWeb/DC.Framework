﻿using Nest;
using System;
using System.Threading.Tasks;

namespace Ding.Elasticsearch.Extensions
{
    /// <summary>
    /// ES客户端(<see cref="IElasticClient"/>) 扩展
    /// </summary>
    internal static class ElasticClientExtensions
    {
        /// <summary>
        /// 初始化索引映射
        /// </summary>
        /// <param name="client">ES客户端</param>
        /// <param name="indexName">索引名</param>
        public static async Task InitializeIndexMapAsync(this IElasticClient client, string indexName)
        {
            var newName = indexName + DateTime.Now.Ticks;
            var result = await client.CreateIndexAsync(newName,
                x => x.Index(newName)
                    .Settings(o =>
                        o.NumberOfShards(1)
                            .NumberOfReplicas(1)
                            .Setting("max_result_window", int.MaxValue)));
            if (result.Acknowledged)
            {
                await client.AliasAsync(x => x.Add(o => o.Index(newName).Alias(indexName)));
                return;
            }
            throw new ElasticsearchException($"创建索引 {indexName} 失败：{result.ServerError.Error.Reason}");
        }

        /// <summary>
        /// 初始化索引映射
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="client">ES客户端</param>
        /// <param name="indexName">索引名</param>
        public static async Task InitializeIndexMapAsync<T>(this IElasticClient client, string indexName) where T : class
        {
            var newName = indexName + DateTime.Now.Ticks;
            var result = await client.CreateIndexAsync(newName,
                x => x.Index(newName)
                    .Settings(o =>
                        o.NumberOfShards(1)
                            .NumberOfReplicas(1)
                            .Setting("max_result_window", int.MaxValue))
                    .Mappings(m => m.Map<T>(mm => mm.AutoMap())));
            if (result.Acknowledged)
            {
                await client.AliasAsync(x => x.Add(o => o.Index(newName).Alias(indexName)));
                return;
            }
            throw new ElasticsearchException($"创建索引 {indexName} 失败：{result.ServerError.Error.Reason}");
        }

        /// <summary>
        /// 初始化索引映射
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="client">ES客户端</param>
        /// <param name="indexName">索引名</param>
        /// <param name="numberOfShards">分片数</param>
        /// <param name="numberOfReplicas">副本数</param>
        public static async Task InitializeIndexMapAsync<T>(this IElasticClient client, string indexName, int numberOfShards,
            int numberOfReplicas) where T : class
        {
            var newName = indexName + DateTime.Now.Ticks;
            var result = await client.CreateIndexAsync(newName,
                x => x.Index(newName)
                    .Settings(o =>
                        o.NumberOfShards(numberOfShards)
                            .NumberOfReplicas(numberOfReplicas)
                            .Setting("max_result_window", int.MaxValue))
                    .Mappings(m => m.Map<T>(mm => mm.AutoMap())));
            if (result.Acknowledged)
            {
                await client.AliasAsync(x => x.Add(o => o.Index(newName).Alias(indexName)));
                return;
            }
            throw new ElasticsearchException($"创建索引 {indexName} 失败：{result.ServerError.Error.Reason}");
        }

        /// <summary>
        /// 初始化索引映射
        /// </summary>
        /// <typeparam name="T1">实体类型</typeparam>
        /// <typeparam name="T2">实体类型</typeparam>
        /// <param name="client">ES客户端</param>
        /// <param name="indexName">索引名</param>
        public static async Task InitializeIndexMapAsync<T1, T2>(this IElasticClient client, string indexName)
            where T1 : class where T2 : class
        {

        }
    }
}
