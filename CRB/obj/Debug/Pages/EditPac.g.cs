﻿#pragma checksum "..\..\..\Pages\EditPac.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9EA0C5D52D5A534ABD1F7B584F1A36159265C0870A89DB18A51B698AD7BE728A"
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
    /// EditPac
    /// </summary>
    public partial class EditPac : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\Pages\EditPac.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox genderCmb;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\EditPac.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PolisTxt;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pages\EditPac.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddPacBtn;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Pages\EditPac.xaml"
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
            System.Uri resourceLocater = new System.Uri("/CRB;component/pages/editpac.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\EditPac.xaml"
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
            this.genderCmb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 41 "..\..\..\Pages\EditPac.xaml"
            this.genderCmb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.genderCmb_SelectionChanged_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PolisTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.AddPacBtn = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\Pages\EditPac.xaml"
            this.AddPacBtn.Click += new System.Windows.RoutedEventHandler(this.AddPacBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CancelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\Pages\EditPac.xaml"
            this.CancelBtn.Click += new System.Windows.RoutedEventHandler(this.CancelBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

