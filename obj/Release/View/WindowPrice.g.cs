﻿#pragma checksum "..\..\..\View\WindowPrice.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "191A71089AF8E94126F2518DF9514139EBB5C22B14AAED7864583C4A0F204BA3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WPFProject.View;


namespace WPFProject.View {
    
    
    /// <summary>
    /// WindowPrice
    /// </summary>
    public partial class WindowPrice : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\View\WindowPrice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button menu;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\View\WindowPrice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbSort;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\View\WindowPrice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbCateg;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\View\WindowPrice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tb_Search;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\View\WindowPrice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Clear;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\View\WindowPrice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbCount;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\View\WindowPrice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GridPrice;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFProject;component/view/windowprice.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\WindowPrice.xaml"
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
            
            #line 17 "..\..\..\View\WindowPrice.xaml"
            ((WPFProject.View.WindowPrice)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.menu = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\View\WindowPrice.xaml"
            this.menu.Click += new System.Windows.RoutedEventHandler(this.menu_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CbSort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 55 "..\..\..\View\WindowPrice.xaml"
            this.CbSort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbSort_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CbCateg = ((System.Windows.Controls.ComboBox)(target));
            
            #line 60 "..\..\..\View\WindowPrice.xaml"
            this.CbCateg.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbCateg_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Tb_Search = ((System.Windows.Controls.TextBox)(target));
            
            #line 61 "..\..\..\View\WindowPrice.xaml"
            this.Tb_Search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Clear = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\View\WindowPrice.xaml"
            this.Clear.Click += new System.Windows.RoutedEventHandler(this.BC_Clear);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tbCount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.GridPrice = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

