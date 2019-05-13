﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using Ding.Ui.Angular.Forms.Configs;
using Ding.Ui.Renders;
using Ding.Ui.TagHelpers;
using Ding.Ui.Zorro.Enums;
using Ding.Ui.Zorro.Forms.Base;
using Ding.Ui.Zorro.Forms.Renders;

namespace Ding.Ui.Zorro.Forms {
    /// <summary>
    /// 日期选择
    /// </summary>
    [HtmlTargetElement( "util-date-picker" )]
    public class DatePickerTagHelper : FormControlTagHelperBase {
        /// <summary>
        /// 日期选择器类型
        /// </summary>
        public DatePickerType Type { get; set; }
        /// <summary>
        /// nzFormat,格式化字符串，格式说明：
        /// 1. 年 - yyyy
        /// 2. 月 - MM
        /// 3. 日 - dd
        /// 4. 时 - HH
        /// 5. 分 - mm
        /// 6. 秒 - ss
        /// 7. 毫秒 - SSS
        /// </summary>
        public string Format { get; set; }
        /// <summary>
        /// nzShowTime,显示时间
        /// </summary>
        public bool ShowTime { get; set; }

        /// <summary>
        /// 获取渲染器
        /// </summary>
        /// <param name="context">上下文</param>
        protected override IRender GetRender( Context context ) {
            var config = new TextBoxConfig( context ) { IsDatePicker = true };
            return new TextBoxRender( config );
        }
    }
}