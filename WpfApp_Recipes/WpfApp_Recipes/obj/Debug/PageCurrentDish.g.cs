﻿#pragma checksum "..\..\PageCurrentDish.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D1E178203D9909C7C2339AF4DC0A4ACDD147DA4D92D089D25153D0B7B42BAAF0"
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
using WpfApp_Recipes;


namespace WpfApp_Recipes {
    
    
    /// <summary>
    /// PageCurrentDish
    /// </summary>
    public partial class PageCurrentDish : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\PageCurrentDish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblCategory;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\PageCurrentDish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblFullTime;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\PageCurrentDish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblTotalCost;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\PageCurrentDish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnMinus;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\PageCurrentDish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtServices;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\PageCurrentDish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnPlus;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\PageCurrentDish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnStartCooking;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp_Recipes;component/pagecurrentdish.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PageCurrentDish.xaml"
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
            this.LblCategory = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.LblFullTime = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.LblTotalCost = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.BtnMinus = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\PageCurrentDish.xaml"
            this.BtnMinus.Click += new System.Windows.RoutedEventHandler(this.BtnMinus_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TxtServices = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.BtnPlus = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\PageCurrentDish.xaml"
            this.BtnPlus.Click += new System.Windows.RoutedEventHandler(this.BtnPlus_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnStartCooking = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\PageCurrentDish.xaml"
            this.BtnStartCooking.Click += new System.Windows.RoutedEventHandler(this.BtnStartCooking_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

