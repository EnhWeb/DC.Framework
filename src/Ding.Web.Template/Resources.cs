using System;
using System.Collections.Generic;
using System.Text;

namespace Ding.Web.FPTemplate
{
    /// <summary>
    ///资源操作
    /// </summary>
    public class Resources
    {
        /// <summary>
        /// 合并集合
        /// </summary>
        /// <param name="oldPaths">原路径集合</param>
        /// <param name="newPaths">待合并的路径集合</param>
        /// <returns>新的路径集合</returns>
        public static IEnumerable<String> MergerPaths(IEnumerable<String> oldPaths, params String[] newPaths)
        {
            List<String> list = new List<String>();
            if (newPaths != null)
            {
                list.AddRange(newPaths);
            }
            if (oldPaths != null)
            {
                list.AddRange(oldPaths);
            }
            return list;
        }

        /// <summary>
        /// 查找指定文件
        /// </summary>
        /// <param name="filename">文件名 允许相对路径.路径分隔符只能使用/</param>
        /// <param name="fullPath">查找结果：完整路径</param>
        /// <returns>路径索引</returns>
        public static Int32 FindPath(String filename, out String fullPath)
        {
            return FindPath(Engine.ResourceDirectories, filename, out fullPath);
        }

        /// <summary>
        /// 查找指定文件
        /// </summary>
        /// <param name="paths">检索路径</param>
        /// <param name="filename">文件名 允许相对路径.路径分隔符只能使用/</param>
        /// <param name="fullPath">查找结果：完整路径</param>
        /// <returns>路径索引</returns>
        public static Int32 FindPath(IEnumerable<String> paths, String filename, out String fullPath)
        {
            //filename 允许单纯的文件名或相对路径
            fullPath = null;

            if (!String.IsNullOrEmpty(filename))
            {
                if ((filename = NormalizePath(filename)) == null)  //路径非法，比如用户试图跳出当前目录时（../header.txt）
                {
                    return -1;
                }

                Int32 i = 0;
                foreach (String checkUrl in paths)
                {
                    if (checkUrl[checkUrl.Length - 1] != System.IO.Path.DirectorySeparatorChar)
                    {
                        fullPath = String.Concat(checkUrl, filename);
                    }
                    else
                    {
                        fullPath = String.Concat(checkUrl.Remove(checkUrl.Length - 1, 1), filename);
                    }
                    if (System.IO.File.Exists(fullPath))
                    {
                        return i;
                    }
                    i++;
                }

            }
            return -1;
        }

        /// <summary>
        /// 加载资源
        /// </summary>
        /// <param name="paths">检索路径</param>
        /// <param name="filename">文件名</param>
        /// <param name="encoding">编码</param>
        /// <returns>文本内容</returns>
        public static String Load(IEnumerable<String> paths, String filename, Encoding encoding)
        {
            if (paths == null && String.IsNullOrEmpty(filename))
            {
                return null;
            }
            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }
            String full;
            if (FindPath(paths, filename, out full) != -1)
            {
                return LoadResource(full, encoding);
            }
            return null;
        }


        /// <summary>
        /// 加载资源
        /// </summary>
        /// <param name="filename">文件名</param>
        /// <param name="encoding">编码</param>
        /// <returns>文本内容</returns>
        public static String Load(String filename, Encoding encoding)
        {
            return Load(Engine.ResourceDirectories, filename, encoding);
        }

        /// <summary>
        /// 载入文件
        /// </summary>
        /// <param name="fullPath">完整文件路径</param>
        /// <param name="encoding">编码</param>
        /// <returns>文本内容</returns>
        public static String LoadResource(String fullPath, Encoding encoding)
        {
            if (!System.IO.File.Exists(fullPath))
            {
                return null;
            }
            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }
            return System.IO.File.ReadAllText(fullPath, encoding);
        }

        /// <summary>
        /// 根据文件名(允许有相对路径)查找并读取文件
        /// </summary>
        /// <param name="paths">检索目录</param>
        /// <param name="filename">文件名</param>
        /// <param name="encoding">编码</param>
        /// <param name="fullName">完整路径</param>
        /// <returns></returns>
        public static String Load(IEnumerable<String> paths, String filename, Encoding encoding, out String fullName)
        {
            if (IsLocalPath(filename))
            {
                fullName = filename;
            }
            else
            {
                Int32 index = Resources.FindPath(paths,filename, out fullName); //如果是相对路径，则进行路径搜索
                if (index == -1)
                {
                    return null;
                }
            }
            return LoadResource(fullName, encoding);
        }

        /// <summary>
        /// 是否本地路径表达形式
        /// </summary>
        /// <param name="path">路径</param>
        /// <returns></returns>
        public static Boolean IsLocalPath(String path)
        {
            return !String.IsNullOrEmpty(path) &&
                (path.IndexOf(System.IO.Path.VolumeSeparatorChar) != -1 //win下判断是否包含卷分隔符（即：） c:\user\Administrator\default.html
                    || path[0] == '/');
        }

        /// <summary>
        /// 路径处理
        /// </summary>
        /// <param name="filename">待处理文件</param>
        /// <returns>处理后的路径</returns>
        public static String NormalizePath(String filename)
        {
            if (String.IsNullOrEmpty(filename) || filename.IndexOfAny(System.IO.Path.GetInvalidPathChars()) != -1)
            {
                return null;
            }

            List<String> values = new List<String>(filename.Split('/'));

            for (Int32 i = 0; i < values.Count; i++)
            {
                if (values[i] == "." || String.IsNullOrEmpty(values[i]))
                {
                    values.RemoveAt(i);
                    i--;
                }
                else if (values[i] == "..")
                {
                    if (i == 0)
                    {
                        return null;
                    }
                    values.RemoveAt(i);
                    i--;
                    values.RemoveAt(i);
                    i--;
                }
            }

            values.Insert(0, String.Empty);

            return String.Join(System.IO.Path.DirectorySeparatorChar.ToString(), values.ToArray());
        }
    }
}