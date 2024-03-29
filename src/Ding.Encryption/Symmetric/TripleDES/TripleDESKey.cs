﻿namespace Ding.Encryption
{
    /// <summary>
    /// TripleDES 密钥
    /// </summary>
    public class TripleDESKey
    {
        /// <summary>
        /// 密钥
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        public string IV { get; set; }

        /// <summary>
        /// 密钥长度
        /// </summary>
        public TripleDESKeySizeType Size { get; set; }
    }
}
