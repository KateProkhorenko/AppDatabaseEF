﻿#pragma checksum "..\..\..\..\Views\ViewPC.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4DB771A16D6FFC236737397ABE0455C612006CBE"
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
    /// ViewPC
    /// </summary>
    public partial class ViewPC : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\Views\ViewPC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AppDB.Views.ViewPC AddNewPcWnd;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Views\ViewPC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox codeBlock;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Views\ViewPC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox modelBlock;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Views\ViewPC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox speedBlock;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Views\ViewPC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ramBlock;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Views\ViewPC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox hdBlock;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Views\ViewPC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cdBlock;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Views\ViewPC.xaml"
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
            System.Uri resourceLocater = new System.Uri("/AppDB;component/views/viewpc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\ViewPC.xaml"
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
            this.AddNewPcWnd = ((AppDB.Views.ViewPC)(target));
            return;
            case 2:
            this.codeBlock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.modelBlock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.speedBlock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ramBlock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.hdBlock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.cdBlock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.priceBlock = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\..\..\Views\ViewPC.xaml"
            this.priceBlock.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInput);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
