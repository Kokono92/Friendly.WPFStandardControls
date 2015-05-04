﻿using Codeer.Friendly;
using Codeer.Friendly.Windows;
using RM.Friendly.WPFStandardControls.Inside;

namespace RM.Friendly.WPFStandardControls
{

#if ENG
    /// <summary>
    /// VisualTree and LogicalTree utility.
    /// </summary>
#else
    /// <summary>
    /// VisualTreeとLogicalTreeのユーティリティー。
    /// </summary>
#endif
    public static class TreeUtility
    {

#if ENG
        /// <summary>
        /// Enumerate DependencyObject continuing to VisualTree.
        /// </summary>
        /// <param name="start">Start DependencyObject.</param>
        /// <param name="direction">Run direction.</param>
        /// <returns>Enumerated DependencyObject.</returns>
#else
        /// <summary>
        /// VisualTreeに連なるDependencyObjectを列挙。
        /// </summary>
        /// <param name="start">列挙を開始するDependencyObject。</param>
        /// <param name="direction">走査方向。</param>
        /// <returns>列挙されたDependencyObject。</returns>
#endif
        public static WPFDependencyObjectCollection VisualTree(AppVar start, TreeRunDirection direction = TreeRunDirection.Descendants)
        {
            var app = (WindowsAppFriend)start.App;
            WPFStandardControls_3.Injection(app);
            return new WPFDependencyObjectCollection(app[typeof(TreeUtilityInTarget), "VisualTree"](start, direction));
        }

#if ENG
        /// <summary>
        /// Enumerate DependencyObject continuing to LogicalTree.
        /// </summary>
        /// <param name="start">Start DependencyObject.</param>
        /// <param name="direction">Run direction.</param>
        /// <returns>Enumerated DependencyObject.</returns>
#else
        /// <summary>
        /// LogicalTreeに連なるDependencyObjectを列挙。
        /// </summary>
        /// <param name="start">列挙を開始するDependencyObject。</param>
        /// <param name="direction">走査方向。</param>
        /// <returns>列挙されたDependencyObject。</returns>
#endif
        public static WPFDependencyObjectCollection LogicalTree(AppVar start, TreeRunDirection direction = TreeRunDirection.Descendants)
        {
            var app = (WindowsAppFriend)start.App;
            WPFStandardControls_3.Injection(app);
            return new WPFDependencyObjectCollection(app[typeof(TreeUtilityInTarget), "LogicalTree"](start, direction));
        }
    }
}
