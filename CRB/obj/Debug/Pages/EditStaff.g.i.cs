﻿#pragma checksum "..\..\..\Pages\EditStaff.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E380EC58C1F6296DAD674DD56816EFE787A768DD9A21BB1B54E8FC3A42E964FB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CRB.Pages;
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


namespace CRB.Pages {
    
    
    /// <summary>
    /// EditStaff
    /// </summary>
    public partial class EditStaff : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Pages\EditStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FmTxt;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Pages\EditStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTxt;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\EditStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OtchTxt;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\EditStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LogTxt;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\EditStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PassTxt;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\EditStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox RoleCmb;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\EditStaff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/CRB;component/pages/editstaff.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\EditStaff.xaml"
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
            
            #line 10 "..\..\..\Pages\EditStaff.xaml"
            ((CRB.Pages.EditStaff)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FmTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.NameTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.OtchTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.LogTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.PassTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.RoleCmb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 38 "..\..\..\Pages\EditStaff.xaml"
            this.RoleCmb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.RoleCmb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 40 "..\..\..\Pages\EditStaff.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CancelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Pages\EditStaff.xaml"
            this.CancelBtn.Click += new System.Windows.RoutedEventHandler(this.CancelBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

