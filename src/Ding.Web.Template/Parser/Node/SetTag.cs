using System;

namespace Ding.Web.FPTemplate.Parser.Node
{
    /// <summary>
    /// 赋值标签
    /// </summary>
    public class SetTag : TagBase
    {
        private String _name;
        private Tag _value;

        /// <summary>
        /// 变量名
        /// </summary>
        public String Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        /// <summary>
        /// 值
        /// </summary>
        public Tag Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        /// <summary>
        /// 解析标签
        /// </summary>
        /// <param name="context">上下文</param>
        public override Object Parse(TemplateContext context)
        {
            Object value = this.Value.Parse(context);
            if (!context.TempData.SetValue(this.Name,value))
            {
                context.TempData.Push(this.Name, value);
            }
            return null;
        }
        /// <summary>
        /// 解析标签
        /// </summary>
        /// <param name="context">上下文</param>
        /// <param name="write">write</param>
        public override void Parse(TemplateContext context, System.IO.TextWriter write)
        {
            Parse(context);
        }
    }
}