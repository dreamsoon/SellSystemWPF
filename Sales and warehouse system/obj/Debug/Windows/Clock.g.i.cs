﻿#pragma checksum "..\..\..\Windows\Clock.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "339F5B71916A870C6D9C047982E73D9C9BAA4BE7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Arash.PersianDateControls;
using Microsoft.Windows.Controls;
using RootLibrary.WPF.Localization;
using Sales_and_warehouse_system.Windows;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Sales_and_warehouse_system.Windows {
    
    
    /// <summary>
    /// Clock
    /// </summary>
    public partial class Clock : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Windows\Clock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_clockname;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Windows\Clock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Arash.PersianDateControls.PersianDatePicker calnder1;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Windows\Clock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_calnder;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Windows\Clock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rectangleSecond;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Windows\Clock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.RotateTransform secondHand;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Windows\Clock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rectangleMinute;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Windows\Clock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.RotateTransform minuteHand;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Windows\Clock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rectangleHour;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Windows\Clock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.RotateTransform hourHand;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Sales and warehouse system;component/windows/clock.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\Clock.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lbl_clockname = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.calnder1 = ((Arash.PersianDateControls.PersianDatePicker)(target));
            return;
            case 3:
            this.lbl_calnder = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.rectangleSecond = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 5:
            this.secondHand = ((System.Windows.Media.RotateTransform)(target));
            return;
            case 6:
            this.rectangleMinute = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 7:
            this.minuteHand = ((System.Windows.Media.RotateTransform)(target));
            return;
            case 8:
            this.rectangleHour = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 9:
            this.hourHand = ((System.Windows.Media.RotateTransform)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

