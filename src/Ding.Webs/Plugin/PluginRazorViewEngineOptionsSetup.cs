﻿using Ding.Extension;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Linq;

namespace Ding.Webs.Plugin
{
    public class PluginRazorViewEngineOptionsSetup : ConfigureOptions<RazorViewEngineOptions>
    {
        public PluginRazorViewEngineOptionsSetup(IHostingEnvironment hostingEnvironment, IPluginLoader loader) :
            base(options =>
            {
                if (hostingEnvironment.IsDevelopment())
                {
                    options.FileProviders.Add(new DeveloperViewFileProvider(hostingEnvironment));
                }
                options.AllowRecompilingViewsOnFileChange = true;
                loader.GetPlugins().Where(m => m.Enable && m.ID.IsNotNullAndWhiteSpace()).Each(m =>
                {
                    var directory = new DirectoryInfo(m.RelativePath);
                    if (hostingEnvironment.IsDevelopment())
                    {
                        options.ViewLocationFormats.Add($"{DeveloperViewFileProvider.ProjectRootPath}{directory.Name}" + "/Views/{0}" + RazorViewEngine.ViewExtension);
                        options.ViewLocationFormats.Add($"{DeveloperViewFileProvider.ProjectRootPath}{directory.Name}" + "/Views/{1}/{0}" + RazorViewEngine.ViewExtension);
                        options.ViewLocationFormats.Add($"{DeveloperViewFileProvider.ProjectRootPath}{directory.Name}" + "/Views/Shared/{0}" + RazorViewEngine.ViewExtension);
                    }
                    else
                    {
                        options.ViewLocationFormats.Add($"/wwwroot/{Loader.PluginFolder}/{directory.Name}" + "/Views/{0}" + RazorViewEngine.ViewExtension);
                        options.ViewLocationFormats.Add($"/wwwroot/{Loader.PluginFolder}/{directory.Name}" + "/Views/{1}/{0}" + RazorViewEngine.ViewExtension);
                        options.ViewLocationFormats.Add($"/wwwroot/{Loader.PluginFolder}/{directory.Name}" + "/Views/Shared/{0}" + RazorViewEngine.ViewExtension);
                    }
                });
                options.ViewLocationFormats.Add("/Views/{0}" + RazorViewEngine.ViewExtension);
            })
        {

        }
    }
}
