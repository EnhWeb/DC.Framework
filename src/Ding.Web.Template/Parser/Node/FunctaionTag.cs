using System;

namespace Ding.Web.FPTemplate.Parser.Node
{
    /// <summary>
    /// 函数（方法）标签
    /// </summary>
    public class FunctaionTag : SimpleTag
    {
        private String _name;
        /// <summary>
        /// 方法名
        /// </summary>
        public String Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        /// <summary>
        /// 解析标签
        /// </summary>
        /// <param name="context">上下文</param>
        public override Object Parse(TemplateContext context)
        {
            Object[] args = new Object[Children.Count];
            for (Int32 i = 0; i < this.Children.Count; i++)
            {
                args[i] = Children[i].Parse(context);
            }

            Object result = context.TempData[this._name];

            if (result != null)
            {
                if (result is FuncHandler)
                {
                    return (result as FuncHandler).Invoke(args);
                }
            }

            return null;
        }
        /// <summary>
        /// 解析标签
        /// </summary>
        /// <param name="context">上下文</param>
        /// <param name="baseValue">baseValue</param>
        public override Object Parse(Object baseValue, TemplateContext context)
        {
            if (baseValue != null)
            {
                Object[] args = new Object[Children.Count];
                for (Int32 i = 0; i < Children.Count; i++)
                {
                    args[i] = Children[i].Parse(context);
                }

                Object result = Dynamic.DynamicHelper.ExcuteMethod(baseValue, this._name, args);

                if (result != null)
                {
                    return result;
                }

                result = Dynamic.DynamicHelper.GetPropertyOrField(baseValue, this._name);

                if (result != null && result is FuncHandler)
                {
                    return (result as FuncHandler).Invoke(args);
                }
            }

            return null;
        }

    }
}