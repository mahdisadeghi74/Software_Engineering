﻿#pragma checksum "..\..\AddMedicinePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2C598D43A74D94D0F5B8E28FE83FDF6516B48CF3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Software_Engineering;
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


namespace Software_Engineering {
    
    
    /// <summary>
    /// AddMedicinePage
    /// </summary>
    public partial class AddMedicinePage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\AddMedicinePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _txtID;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AddMedicinePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _txtName;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AddMedicinePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _txtPrice;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\AddMedicinePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _btnAdd;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AddMedicinePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _btnExit;
        
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
            System.Uri resourceLocater = new System.Uri("/Software_Engineering;component/addmedicinepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddMedicinePage.xaml"
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
            this._txtID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this._txtName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this._txtPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this._btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\AddMedicinePage.xaml"
            this._btnAdd.Click += new System.Windows.RoutedEventHandler(this._btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this._btnExit = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\AddMedicinePage.xaml"
            this._btnExit.Click += new System.Windows.RoutedEventHandler(this._btnExit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
