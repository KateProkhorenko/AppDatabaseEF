﻿#pragma checksum "..\..\..\..\Views\ViewPrinter.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D4738ACD34D7E6ABB1B6ACDFB9E1FEC05153321F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AppDB.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace AppDB.Views {
    
    
    /// <summary>
    /// ViewPrinter
    /// </summary>
    public partial class ViewPrinter : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\Views\ViewPrinter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AppDB.Views.ViewPrinter AddNewPrinterWnd;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Views\ViewPrinter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox codeBlock;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Views\ViewPrinter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox modelBlock;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Views\ViewPrinter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox colorBlock;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Views\ViewPrinter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox typeBlock;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Views\ViewPrinter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox priceBlock;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AppDB;V1.0.0.0;component/views/viewprinter.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\ViewPrinter.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.AddNewPrinterWnd = ((AppDB.Views.ViewPrinter)(target));
            return;
            case 2:
            this.codeBlock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.modelBlock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.colorBlock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.typeBlock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.priceBlock = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\..\Views\ViewPrinter.xaml"
            this.priceBlock.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInput);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
