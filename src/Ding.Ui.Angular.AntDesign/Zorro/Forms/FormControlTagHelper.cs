﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using Ding.Ui.Angular.Base;
using Ding.Ui.Configs;
using Ding.Ui.Renders;
using Ding.Ui.TagHelpers;
using Ding.Ui.Zorro.Forms.Renders;

namespace Ding.Ui.Zorro.Forms {
    /// <summary>
    /// 表单控件
    /// </summary>
    [HtmlTargetElement( "util-form-control" )]
    public class FormControlTagHelper : AngularTagHelperBase {
        /// <summary>
        /// [nzSpan],24栅格占位格数，可选值: 0 - 24, 为 0 时隐藏
        /// </summary>
        public int Span { get; set; }
        /// <summary>
        /// [nzOffset],栅格左侧偏移的间隔格数
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// 获取渲染器
        /// </summary>
        /// <param name="context">上下文</param>
        protected override IRender GetRender( Context context ) {
            return new FormControlRender( new Config( context ) );
        }
    }
}