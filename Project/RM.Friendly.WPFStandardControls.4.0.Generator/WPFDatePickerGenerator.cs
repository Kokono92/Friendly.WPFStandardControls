﻿using System;
using System.Collections.Generic;
using Codeer.TestAssistant.GeneratorToolKit;
using System.Windows.Controls;

namespace RM.Friendly.WPFStandardControls.Generator
{
    public class WPFDatePickerGenerator : GeneratorBase
    {
        DatePicker _control;

        protected override void Attach()
        {
            _control = (DatePicker)ControlObject;
            _control.SelectedDateChanged += SelectedDateChanged;
        }

        protected override void Detach()
        {
            _control.SelectedDateChanged -= SelectedDateChanged;
        }

        void SelectedDateChanged(object sender, EventArgs e)
        {
            if (_control.SelectedDate.Value != null)
            {
                DateTime day = _control.SelectedDate.Value;
                AddSentence(new TokenName(), ".EmulateChangeDate(new DateTime(", day.Year, ", ", day.Month, ", ", day.Day, ")", new TokenAsync(CommaType.Before), ");");
            }
        }
    }
}
