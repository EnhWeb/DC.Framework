using System;

namespace Ding.Web.FPTemplate.Parser.Node
{
    /// <summary>
    /// 文本标签
    /// </summary>
    public class TextTag : Tag
    {
        /// <summary>
        /// 解析标签
        /// </summary>
        /// <param name="context">上下文</param>
        public override object Parse(TemplateContext context)
        {
            if(context.StripWhiteSpace)
            {
                return (this.ToString() ?? string.Empty).Trim();
            }
            return this.ToString();
        }
        /// <summary>
        /// 解析标签
        /// </summary>
        /// <param name="context">上下文</param>
        /// <param name="write">write</param>
        public override void Parse(TemplateContext context, System.IO.TextWriter write)
        {
            String value = this.ToString();
            if (context.StripWhiteSpace 
                && value!=null)
            {
                value = value.Trim();
            }
            write.Write(value);
        }

        /// <summary>
        /// 获取对象的字符串引用
        /// </summary>
        public override String ToString()
        {
            return this.FirstToken.ToString();
        }

    }
}