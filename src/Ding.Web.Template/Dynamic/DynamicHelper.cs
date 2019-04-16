﻿using System;
using System.Collections;

namespace Ding.Web.FPTemplate.Dynamic
{
    /// <summary>
    /// 动态辅助类
    /// </summary>
    public class DynamicHelper
    {
        private static IProvider provider;
        /// <summary>
        /// DynamicHelpers
        /// </summary>
        internal static IProvider Instance
        {
            get
            {
                if (provider == null)
                {
                    provider = new ReflectionProvider();
                    //if (Engine.Runtime.Cache == null)
                    //{
                    //    helper = new ReflectionHelpers();
                    //}
                    //else
                    //{
                    //    helper = new ILHelpers();
                    //}
                }

                return provider;
            }
            set
            {
                provider = value;
            }
        }

        /// <summary>
        /// 动态执行方法
        /// </summary>
        /// <param name="container">对象</param>
        /// <param name="methodName">方法名</param>
        /// <param name="args">实参</param>
        /// <returns>执行结果（Void返回NULL）</returns>
        public static Object ExcuteMethod(Object container, String methodName, Object[] args)
        {
            return Instance.ExcuteMethod(container, methodName, args);
        }
        /// <summary>
        /// 动态获取属性或字段
        /// </summary>
        /// <param name="value">对象</param>
        /// <param name="propertyName">属性或字段名</param>
        /// <returns>返回结果</returns>
        public static Object GetPropertyOrField(Object value, String propertyName)
        {
            return Instance.GetPropertyOrField(value, propertyName);
        }

        #region ToIEnumerable
        /// <summary>
        /// 将对象转换为IEnumerable
        /// </summary>
        /// <param name="dataSource">源对象</param>
        /// <returns>IEnumerable</returns>
        public static IEnumerable ToIEnumerable(Object dataSource)
        {
#if NOTDNX
            IListSource source;
#endif
            IEnumerable result;
            if (dataSource == null)
            {
                return null;
            }

            if ((result = dataSource as IEnumerable) != null)
            {
                return result;
            }
#if NOTDNX
            if ((source = dataSource as IListSource) != null)
            {
                IList list = source.GetList();
                if (!source.ContainsListCollection)
                {
                    return list;
                }
                if ((list != null) && (list is ITypedList))
                {
                    PropertyDescriptorCollection itemProperties = ((ITypedList)list).GetItemProperties(new PropertyDescriptor[0]);
                    if ((itemProperties == null) || (itemProperties.Count == 0))
                    {
                        return null;
                    }
                    PropertyDescriptor descriptor = itemProperties[0];
                    if (descriptor != null)
                    {
                        Object component = list[0];
                        Object value = descriptor.GetValue(component);
                        if ((value != null) && ((result = value as IEnumerable) != null))
                        {
                            return result;
                        }
                    }
                    return null;
                }
            }
#endif
            return null;

        }
        #endregion
    }
}
