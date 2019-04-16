using System;
using System.Collections.Generic;

namespace Ding.Web.FPTemplate.Parser
{
    /// <summary>
    /// 变量域
    /// </summary>
    public class VariableScope
    {
        private VariableScope _parent;
        private IDictionary<String, Object> _dic;


        /// <summary>
        /// 无参构造函数
        /// </summary>
        public VariableScope()
            : this(null, null)
        {

        }

        /// <summary>
        /// 以字典来初始化对象
        /// </summary>
        /// <param name="dictionary">初始化字典</param>
        public VariableScope(IDictionary<String, Object> dictionary)
            : this(null, dictionary)
        {

        }

        /// <summary>
        /// 以父VariableScope与字典来初始化对象
        /// </summary>
        /// <param name="parent">父VariableScope</param>
        /// <param name="dictionary">初始化字典</param>
        public VariableScope(VariableScope parent, IDictionary<String, Object> dictionary)
        {
            this._parent = parent;
            this._dic = dictionary ?? new Dictionary<String, Object>(Engine.ComparerIgnoreCase);
        }

        /// <summary>
        /// 以父VariableScope来初始化对象
        /// </summary>
        /// <param name="parent">父VariableScope</param>
        public VariableScope(VariableScope parent) :
            this(parent, null)
        {

        }

        /// <summary>
        /// 清空数据
        /// </summary>
        /// <param name="all">是否清空父数据</param>
        public void Clear(Boolean all)
        {
            this._dic.Clear();
            if (all
                && this._parent != null)
            {
                this._parent.Clear(all);
            }
        }

        /// <summary>
        /// 清空数据
        /// </summary>
        public void Clear()
        {
            Clear(false);
        }

        /// <summary>
        /// 父对象
        /// </summary>
        public VariableScope Parent
        {
            get { return this._parent; }
        }

        /// <summary>
        /// 获取索引值
        /// </summary>
        /// <param name="name">索引名称</param>
        /// <returns>Object</returns>
        public Object this[String name]
        {
            get
            {
                Object val;
                if (this._dic.TryGetValue(name, out val))
                {
                    return val;
                }
                if (this._parent != null)
                {
                    return this._parent[name];
                }
                return null;
            }
            set
            {
                this._dic[name] = value;
            }
        }

        /// <summary>
        /// 为已有键设置新的值(本方法供set标签做特殊处理使用)
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        internal Boolean SetValue(String key, Object value)
        {

            if (this._dic.ContainsKey(key))
            {
                this[key] = value;
                return true;
            }
            if (this._parent != null)
            {
                return this._parent.SetValue(key, value);
            }
            return false;
        }

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        public void Push(String key, Object value)
        {
            this._dic.Add(key, value);
        }

        /// <summary>
        /// 是否包含指定键
        /// </summary>
        /// <param name="key">键</param>
        /// <returns>Boolean</returns>
        public Boolean ContainsKey(String key)
        {
            if (this._dic.ContainsKey(key))
            {
                return true;
            }
            if (_parent != null)
            {
                return this._parent.ContainsKey(key);
            }

            return false;
        }

        /// <summary>
        /// 移除指定对象
        /// </summary>
        /// <param name="key"></param>
        /// <returns>是否移除成功</returns>
        public Boolean Remove(String key)
        {
            return this._dic.Remove(key);
        }

    }
}