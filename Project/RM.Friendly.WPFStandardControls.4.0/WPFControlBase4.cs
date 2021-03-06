﻿using System;
using Codeer.Friendly;
using Codeer.Friendly.Windows;
using RM.Friendly.WPFStandardControls.Inside;
using System.Windows;

namespace RM.Friendly.WPFStandardControls
{
#if ENG
    /// <summary>
    /// This is the base class for classes that operate on basic controls in .Net4.0 System.Windows.Controls.
    /// </summary>
#else
    /// <summary>
    /// .Net4.0のWPFのコントロールを操作するためのクラスの基本クラスです。
    /// </summary>
#endif
    public class WPFControlBase4<CoreType> : WPFControlBase<CoreType> where CoreType : UIElement
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
        protected WPFControlBase4(AppVar appVar)
            : base(appVar)
        {
            WPFStandardControls_4.Injection((WindowsAppFriend)appVar.App);
        }
    }
}
