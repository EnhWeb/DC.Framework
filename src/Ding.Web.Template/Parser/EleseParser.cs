using Ding.Web.FPTemplate.Parser.Node;

namespace Ding.Web.FPTemplate.Parser
{
    /// <summary>
    /// ELSE标签分析器
    /// </summary>
    public class EleseParser : ITagParser
    {
        #region ITagParser 成员
        /// <summary>
        /// 分析标签
        /// </summary>
        /// <param name="parser">TemplateParser</param>
        /// <param name="tc">Token集合</param>
        /// <returns></returns>
        public Tag Parse(TemplateParser parser, TokenCollection tc)
        {
            if (tc != null
                && parser != null
                && tc.Count == 1
                && Common.Utility.IsEqual(tc.First.Text, Field.KEY_ELSE))
            {
                return new ElseTag();
            }

            return null;
        }
        #endregion
    }
}