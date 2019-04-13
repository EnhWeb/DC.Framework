﻿using System;

namespace Ding.Web.FPTemplate.Common
{
    /// <summary>
    /// 公用类
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// 字符串转布尔
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static Boolean ToBoolean(String input)
        {
            if ("true".Equals(input, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 是否英文字母
        /// </summary>
        /// <param name="value">字符</param>
        /// <returns></returns>
        public static Boolean IsLetter(Char value)
        {
            return Char.IsLower(value) || Char.IsUpper(value);
        }
        /// <summary>
        /// 是否单词
        /// </summary>
        /// <param name="value">字符</param>
        /// <returns></returns>
        public static Boolean IsWord(Char value)
        {
            return Char.IsLower(value) || Char.IsUpper(value) || Char.IsNumber(value) || value == '_';
        }
        /// <summary>
        /// 字符串是否相同
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Boolean IsEqual(String x, String y)
        {
            if (x == null || y == null)
                return x == y;
            return String.Equals(x, y, Engine.ComparisonIgnoreCase);
        }
    }
}
