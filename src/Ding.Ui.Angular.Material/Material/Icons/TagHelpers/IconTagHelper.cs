﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using Ding.Ui.Angular.Base;
using Ding.Ui.Enums;
using Ding.Ui.Material.Icons.Configs;
using Ding.Ui.Material.Icons.Renders;
using Ding.Ui.Renders;
using Ding.Ui.TagHelpers;

namespace Ding.Ui.Material.Icons.TagHelpers {
    /// <summary>
    /// 图标
    /// </summary>
    [HtmlTargetElement( "util-icon" )]
    public class IconTagHelper : AngularTagHelperBase {
        /// <summary>
        /// Font Awesome图标
        /// </summary>
        public FontAwesomeIcon FontAwesomeIcon { get; set; }
        /// <summary>
        /// Font Awesome图标绑定
        /// </summary>
        public string BindFontAwesomeIcon { get; set; }
        /// <summary>
        /// Material图标
        /// </summary>
        public MaterialIcon MaterialIcon { get; set; }
        /// <summary>
        /// Material图标绑定
        /// </summary>
        public string BindMaterialIcon { get; set; }
        /// <summary>
        /// 图标大小
        /// </summary>
        public IconSize Size { get; set; }
        /// <summary>
        /// 持续旋转
        /// </summary>
        public bool Spin { get; set; }
        /// <summary>
        /// 旋转
        /// </summary>
        public RotateType Rotate { get; set; }
        /// <summary>
        /// 子图标
        /// </summary>
        public FontAwesomeIcon Child { get; set; }
        /// <summary>
        /// 子图标class
        /// </summary>
        public string ChildClass { get; set; }

        /// <summary>
        /// 获取渲染器
        /// </summary>
        /// <param name="context">上下文</param>
        protected override IRender GetRender( Context context ) {
            return new IconRender( new IconConfig( context ) );
        }
    }
}