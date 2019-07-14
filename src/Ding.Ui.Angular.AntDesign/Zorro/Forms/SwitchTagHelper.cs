﻿using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Ding.Ui.Angular.Base;
using Ding.Ui.Configs;
using Ding.Ui.Renders;
using Ding.Ui.TagHelpers;
using Ding.Ui.Zorro.Forms.Renders;

namespace Ding.Ui.Zorro.Forms {
    /// <summary>
    /// 开关
    /// </summary>
    [HtmlTargetElement( "util-switch" )]
    public class SwitchTagHelper : AngularTagHelperBase {
        /// <summary>
        /// 属性表达式
        /// </summary>
        public ModelExpression For { get; set; }
        /// <summary>
        /// 是否显示标签，默认值：false
        /// </summary>
        public bool ShowLabel { get; set; }
        /// <summary>
        /// 标签文本
        /// </summary>
        public string LabelText { get; set; }
        /// <summary>
        /// 标签的栅格占位格数
        /// </summary>
        public int LabelSpan { get; set; }
        /// <summary>
        /// name,控件名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// [name],控件名称
        /// </summary>
        public string BindName { get; set; }
        /// <summary>
        /// nzDisabled,禁用
        /// </summary>
        public bool Disabled { get; set; }
        /// <summary>
        /// [nzDisabled],禁用
        /// </summary>
        public string BindDisabled { get; set; }
        /// <summary>
        /// [(ngModel)],模型绑定
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// nzSpan,24栅格占位格数，可选值: 0 - 24, 为 0 时隐藏
        /// </summary>
        public int Span { get; set; }
        /// <summary>
        /// (ngModelChange),变更事件处理函数
        /// </summary>
        public string OnChange { get; set; }

        /// <summary>
        /// 获取渲染器
        /// </summary>
        /// <param name="context">上下文</param>
        protected override IRender GetRender( Context context ) {
            return new SwitchRender( new Config( context ) );
        }
    }
}
