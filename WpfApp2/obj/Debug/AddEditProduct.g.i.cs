﻿#pragma checksum "..\..\AddEditProduct.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "98CEB966C620EE65242E114C89F0FE3C2C3E774C00DDAB6909E4B6C13B1058C9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfApp2;


namespace WpfApp2 {
    
    
    /// <summary>
    /// AddEditProduct
    /// </summary>
    public partial class AddEditProduct : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\AddEditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid AddEditeEmployee;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\AddEditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tboxName;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddEditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tboxPrice;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\AddEditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tboxAvilebleCount;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AddEditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtPCancel;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\AddEditProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtPOkay;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/addeditproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddEditProduct.xaml"
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
            this.AddEditeEmployee = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.tboxName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tboxPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tboxAvilebleCount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.BtPCancel = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\AddEditProduct.xaml"
            this.BtPCancel.Click += new System.Windows.RoutedEventHandler(this.BtPCancel_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtPOkay = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\AddEditProduct.xaml"
            this.BtPOkay.Click += new System.Windows.RoutedEventHandler(this.BtPOkay_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

