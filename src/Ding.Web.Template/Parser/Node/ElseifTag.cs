using System;

namespace Ding.Web.FPTemplate.Parser.Node
{
    /// <summary>
    /// ELSE if 标签
    /// </summary>
    public class ElseifTag : TagBase
    {

        private Tag _test;
        /// <summary>
        /// 条件
        /// </summary>
        public virtual Tag Test
        {
            get { return this._test; }
            set { this._test = value; }
        }
        /// <summary>
        /// 解析标签
        /// </summary>
        /// <param name="context">上下文</param>
        public override Object Parse(TemplateContext context)
        {
            if (Children.Count == 1)
            {
                return Children[0].Parse(context);
            }
            else
            {
                using (System.IO.StringWriter write = new System.IO.StringWriter())
                {
                    for (Int32 i = 0; i < Children.Count; i++)
                    {
                        Children[i].Parse(context, write);
                    }
                    return write.ToString();
                }
            }

        }

        /// <summary>
        /// 解析标签
        /// </summary>
        /// <param name="context">上下文</param>
        /// <param name="write">write</param>
        public override void Parse(TemplateContext context, System.IO.TextWriter write)
        {
            for (Int32 i = 0; i < Children.Count; i++)
            {
                Children[0].Parse(context, write);
            }
        }

        /// <summary>
        /// 获取布布值
        /// </summary>
        /// <param name="context">上下文</param>
        public override Boolean ToBoolean(TemplateContext context)
        {
            return this._test.ToBoolean(context);
        }

    }
}