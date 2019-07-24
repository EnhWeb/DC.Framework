﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using Ding.Ui.Angular.Base;
using Ding.Ui.Configs;
using Ding.Ui.Renders;
using Ding.Ui.TagHelpers;
using Ding.Ui.Zorro.Grid.Renders;

namespace Ding.Ui.Zorro.Grid {
    /// <summary>
    /// 栅格布局 - 列
    /// </summary>
    [HtmlTargetElement( "util-column")]
    public class ColumnTagHelper : AngularTagHelperBase {
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
            return new ColumnRender( new Config( context ) );
        }
    }
}