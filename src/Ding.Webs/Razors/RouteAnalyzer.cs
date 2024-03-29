﻿using System.Collections.Generic;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using Ding.Webs.Filters;

namespace Ding.Webs.Razors {
    /// <summary>
    /// 路由分析器
    /// </summary>
    public class RouteAnalyzer : IRouteAnalyzer {
        /// <summary>
        /// 操作描述集合提供程序
        /// </summary>
        private readonly IActionDescriptorCollectionProvider _actionDescriptorCollectionProvider;

        /// <summary>
        /// 页面加载器
        /// </summary>
        private readonly IPageLoader _pageLoader;

        /// <summary>
        /// 初始化一个<see cref="RouteAnalyzer"/>类型的实例
        /// </summary>
        /// <param name="actionDescriptorCollectionProvider">操作描述集合提供程序</param>
        /// <param name="pageLoader">页面加载器</param>
        public RouteAnalyzer( IActionDescriptorCollectionProvider actionDescriptorCollectionProvider , IPageLoader pageLoader ) {
            _actionDescriptorCollectionProvider = actionDescriptorCollectionProvider;
            _pageLoader = pageLoader;
        }

        /// <summary>
        /// 获取所有路由信息
        /// </summary>
        public IEnumerable<RouteInformation> GetAllRouteInformations() {
            List<RouteInformation> list = new List<RouteInformation>();

            var actionDescriptors = this._actionDescriptorCollectionProvider.ActionDescriptors.Items;
            foreach( var actionDescriptor in actionDescriptors ) {
                RouteInformation info = new RouteInformation();
                if( actionDescriptor.RouteValues.ContainsKey( "area" ) ) {
                    info.AreaName = actionDescriptor.RouteValues["area"];
                }
                // Razor页面路径以及调用
                if( actionDescriptor is PageActionDescriptor pageActionDescriptor )
                {
                    var compiledPage = _pageLoader.Load(pageActionDescriptor);
                    info.Path = pageActionDescriptor.ViewEnginePath;
                    info.Invocation = pageActionDescriptor.RelativePath;
                    SetHtmlInfo(info, compiledPage);
                    if (!list.Exists(x => x.Invocation == info.Invocation))
                    {
                        list.Add(info);
                    }
                    continue;
                }
                // 路由属性路径
                if( actionDescriptor.AttributeRouteInfo != null ) {
                    info.Path = $"/{actionDescriptor.AttributeRouteInfo.Template}";
                }
                // Controller/Action 的路径以及调用
                if( actionDescriptor is ControllerActionDescriptor controllerActionDescriptor ) {
                    if( info.Path.IsEmpty() ) {
                        info.Path = $"/{controllerActionDescriptor.ControllerName}/{controllerActionDescriptor.ActionName}";
                    }
                    SetHtmlInfo( info, controllerActionDescriptor );
                    info.ControllerName = controllerActionDescriptor.ControllerName;
                    info.ActionName = controllerActionDescriptor.ActionName;
                    info.Invocation = $"{controllerActionDescriptor.ControllerName}Controller.{controllerActionDescriptor.ActionName}";
                }
                info.Invocation += $"({actionDescriptor.DisplayName})";
                list.Add( info );
            }

            return list;
        }

        /// <summary>
        /// 设置Html信息
        /// </summary>
        /// <param name="routeInformation">路由信息</param>
        /// <param name="controllerActionDescriptor">控制器</param>
        private void SetHtmlInfo( RouteInformation routeInformation,
            ControllerActionDescriptor controllerActionDescriptor ) {
            var htmlAttribute = controllerActionDescriptor.MethodInfo.GetCustomAttribute<HtmlAttribute>() ??
                                controllerActionDescriptor.ControllerTypeInfo.GetCustomAttribute<HtmlAttribute>();
            if( htmlAttribute == null )
                return;
            routeInformation.FilePath = htmlAttribute.Path;
            routeInformation.TemplatePath = htmlAttribute.Template;
            routeInformation.IsPartialView = htmlAttribute.IsPartialView;
            routeInformation.ViewName = htmlAttribute.ViewName;
        }

        /// <summary>
        /// 设置Html信息
        /// </summary>
        /// <param name="routeInformation">路由信息</param>
        /// <param name="compiledPageActionDescriptor">编译后的页面</param>
        private void SetHtmlInfo(RouteInformation routeInformation,
            CompiledPageActionDescriptor compiledPageActionDescriptor)
        {
            routeInformation.IsPageRoute = true;
            var htmlAttribute = compiledPageActionDescriptor.PageTypeInfo.GetCustomAttribute<HtmlAttribute>() ??
                                compiledPageActionDescriptor.DeclaredModelTypeInfo.GetCustomAttribute<HtmlAttribute>();
            if (htmlAttribute == null)
                return;
            routeInformation.FilePath = htmlAttribute.Path;
            routeInformation.TemplatePath = htmlAttribute.Template;
            routeInformation.IsPartialView = htmlAttribute.IsPartialView;
            routeInformation.ViewName = htmlAttribute.ViewName;
        }
    }
}
