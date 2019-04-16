﻿using System;

namespace Ding.Ui.Material.Menus.Wrappers {
    /// <summary>
    /// 菜单包装器
    /// </summary>
    public interface IMenuWrapper : IDisposable {
        /// <summary>
        /// 菜单项
        /// </summary>
        IMenuItem Item();
    }
}