﻿//  Edited by Kokono92, 5/20/2018
//  - Added access methods to CarretIndex property of TextBox
using Codeer.Friendly;
using Codeer.Friendly.Windows;
using System.Windows.Controls;

namespace RM.Friendly.WPFStandardControls
{
#if ENG
    /// <summary>
    /// Provides operations on controls of type System.Windows.Controls.TextBox.
    /// </summary>
#else
    /// <summary>
    /// TypeがSystem.Windows.Controls.TextBoxに対応した操作を提供します。
    /// </summary>
#endif
    public class WPFTextBox : WPFControlBase<TextBox>
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
        public WPFTextBox(AppVar appVar)
            : base(appVar) { }

#if ENG
        /// <summary>
        /// Returns the control's text.
        /// </summary>
#else
        /// <summary>
        /// テキストを取得します。
        /// </summary>
#endif
        public string Text
        {
            get { return Getter<string>("Text"); }
        }

#if ENG
        /// <summary>
        /// Sets the control's text.
        /// </summary>
        /// <param name="text">Text to use.</param>
#else
        /// <summary>
        /// テキストを変更します。
        /// </summary>
        /// <param name="text">テキスト。</param>
#endif
        public void EmulateChangeText(string text)
        {
            InvokeStatic(EmulateChangeText, text);
        }

#if ENG
        /// <summary>
        /// Sets the control's text.
        /// Executes asynchronously. 
        /// </summary>
        /// <param name="text">Text to use.</param>
        /// <param name="async">Asynchronous execution.</param>
#else
        /// <summary>
        /// テキストを変更します。
        /// 非同期で実行します。
        /// </summary>
        /// <param name="text">テキスト。</param>
        /// <param name="async">非同期実行オブジェクト。</param>
#endif
        public void EmulateChangeText(string text, Async async)
        {
            InvokeStatic(EmulateChangeText, async, text);
        }

        private static void EmulateChangeText(TextBox textBox, string value)
        {
            textBox.Focus();
            textBox.Text = value;
        }

#if ENG
        /// <summary>
        /// Returns the control's caretIndex.
        /// </summary>
#else
        /// <summary>
        /// キャレット位置を取得します。
        /// </summary>
#endif
        public int CaretIndex
        {
            get { return Getter<int>("CaretIndex"); }
        }

#if ENG
        /// <summary>
        /// Sets the control's caretIndex.
        /// </summary>
        /// <param name="caretIndex">CaretIndex to use.</param>
#else
        /// <summary>
        /// キャレット位置を変更します。
        /// </summary>
        /// <param name="caretIndex">キャレット位置。</param>
#endif
        public void EmulateChangeCaretIndex(int caretIndex)
        {
            InvokeStatic(EmulateChangeCaretIndex, caretIndex);
        }

#if ENG
        /// <summary>
        /// Sets the control's caretIndex.
        /// Executes asynchronously. 
        /// </summary>
        /// <param name="caretIndex">CaretIndex to use.</param>
        /// <param name="async">Asynchronous execution.</param>
#else
        /// <summary>
        /// キャレット位置を変更します。
        /// 非同期で実行します。
        /// </summary>
        /// <param name="caretIndex">キャレット位置。</param>
        /// <param name="async">非同期実行オブジェクト。</param>
#endif
        public void EmulateChangeCaretIndex(int caretIndex, Async async)
        {
            InvokeStatic(EmulateChangeCaretIndex, async, caretIndex);
        }
        
        private static void EmulateChangeCaretIndex(TextBox textBox, int value)
        {
            textBox.Focus();
            textBox.CaretIndex = value;
        }

    }
}
