﻿using System.Collections.Generic;
using System.Text;

namespace Ding.Datas.Sql.Builders.Conditions {
    /// <summary>
    /// Not In查询条件
    /// </summary>
    public class NotInCondition : ICondition {
        /// <summary>
        /// 列名
        /// </summary>
        private readonly string _name;
        /// <summary>
        /// 值集合
        /// </summary>
        private readonly IList<string> _values;

        /// <summary>
        /// 初始化Not In查询条件
        /// </summary>
        /// <param name="name">列名</param>
        /// <param name="values">值集合</param>
        public NotInCondition( string name,IList<string> values ) {
            _name = name;
            _values = values;
        }

        /// <summary>
        /// 获取查询条件
        /// </summary>
        public string GetCondition() {
            if ( string.IsNullOrWhiteSpace( _name ) || _values == null || _values.Count == 0 )
                return null;
            var result = new StringBuilder();
            result.Append( $"{_name} Not In (" );
            result.Append( _values.JoinT() );
            result.Append( ")" );
            return result.ToString();
        }
    }
}