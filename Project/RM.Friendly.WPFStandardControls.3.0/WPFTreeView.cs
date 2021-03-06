﻿using Codeer.Friendly;
using Codeer.Friendly.Windows;
using RM.Friendly.WPFStandardControls.Inside;
using System;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Media;

namespace RM.Friendly.WPFStandardControls
{
#if ENG
    /// <summary>
    /// Provides operations on controls of type System.Windows.Controls.WPFTreeView.
    /// </summary>
#else
    /// <summary>
    /// TypeがSystem.Windows.Controls.WPFTreeViewに対応した操作を提供します。
    /// </summary>
#endif
    public class WPFTreeView : WPFControlBase<TreeView>
    {
#if ENG
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="appVar">Application variable object for the control.</param>
#else
        /// <summary>
        /// コンストラクタです。
        /// </summary>
        /// <param name="appVar">アプリケーション内変数。</param>
#endif
        public WPFTreeView(AppVar appVar)
            : base(appVar) { }

#if ENG        
        /// <summary>
        /// Get item.
        /// </summary>
        /// <param name="headerTexts">The array of text to the target item. </param>
        /// <returns>Item.</returns>
#else
        /// <summary>
        /// アイテムを取得します。
        /// </summary>
        /// <param name="headerTexts">目的のアイテムまでのテキストの配列です。</param>
        /// <returns>アイテム。</returns>
#endif
        public WPFTreeViewItem GetItem(params string[] headerTexts)
        {
            return new WPFTreeViewItem(InvokeStaticRetAppVar(GetItemInTarget, Ret<TreeViewItem>(), headerTexts));
        }

#if ENG
        /// <summary>
        /// Get item.
        /// </summary>
        /// <param name="indices">The array of index to the target item. </param>
        /// <returns>Item.</returns>
#else
        /// <summary>
        /// アイテムを取得します。
        /// </summary>
        /// <param name="indices">目的のアイテムまでの各階層でのインデックスの配列です。</param>
        /// <returns>アイテム。</returns>
#endif
        public WPFTreeViewItem GetItem(params int[] indices)
        {
            return new WPFTreeViewItem(InvokeStaticRetAppVar(GetItemInTarget, Ret<TreeViewItem>(), indices));
        }

        static TreeViewItem GetItemInTarget(TreeView tree, string[] headerTexts)
        {
            return HeaderedItemsControlUtility.GetItem<TreeViewItem>(tree, headerTexts, ShowNextItem);
        }

        static TreeViewItem GetItemInTarget(TreeView tree, int[] indices)
        {
            return HeaderedItemsControlUtility.GetItem<TreeViewItem>(tree, indices, ShowNextItem);
        }

        static void ShowNextItem(TreeViewItem item)
        {
            var peer = new TreeViewItemAutomationPeer(item);
            IExpandCollapseProvider expander = peer;
            expander.Expand();
            InvokeUtility.DoEvents();
        }
    }
}
