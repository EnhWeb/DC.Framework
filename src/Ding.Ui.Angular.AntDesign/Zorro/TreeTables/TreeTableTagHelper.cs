﻿using Ding.Ui.Renders;
using Ding.Ui.TagHelpers;
using Ding.Ui.Zorro.Tables;
using Ding.Ui.Zorro.Tables.Configs;
using Ding.Ui.Zorro.TreeTables.Renders;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Ding.Ui.Zorro.TreeTables {
    /// <summary>
    /// 树形表格
    /// </summary>
    [HtmlTargetElement("util-tree-table")]
    public class TreeTableTagHelper : TableTagHelper {
        /// <summary>
        /// 是否显示复选框，默认为 true
        /// </summary>
        public bool ShowCheckbox { get; set; }
        /// <summary>
        /// 是否展开所有节点，默认为 false
        /// </summary>
        public bool ExpandAll { get; set; }
        /// <summary>
        /// 节点展开事件处理函数
        /// </summary>
        public string OnExpand { get; set; }

        /// <summary>
        /// 获取渲染器
        /// </summary>
        /// <param name="context">上下文</param>
        protected override IRender GetRender( Context context ) {
            var config = new TableConfig( context );
            return new TreeTableRender( config );
        }
    }
}