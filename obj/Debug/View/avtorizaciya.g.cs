﻿#pragma checksum "..\..\..\View\avtorizaciya.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F54B7E1AD444D804DA5BBD4B477A1D6EEC50ECFEF12BF486D8FEA77BF04E38E6"
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
    /// avtorizaciya
    /// </summary>
    public partial class avtorizaciya : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\View\avtorizaciya.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\View\avtorizaciya.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Login;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\View\avtorizaciya.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Password;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\View\avtorizaciya.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PasswordHide;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\View\avtorizaciya.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox pass;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\View\avtorizaciya.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateCatalog;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFProject;component/view/avtorizaciya.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\avtorizaciya.xaml"
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
            
            #line 16 "..\..\..\View\avtorizaciya.xaml"
            ((WPFProject.View.avtorizaciya)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Load);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Exit = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\View\avtorizaciya.xaml"
            this.Exit.Click += new System.Windows.RoutedEventHandler(this.menu_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Login = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.PasswordHide = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.pass = ((System.Windows.Controls.CheckBox)(target));
            
            #line 66 "..\..\..\View\avtorizaciya.xaml"
            this.pass.Click += new System.Windows.RoutedEventHandler(this.Hide);
            
            #line default
            #line hidden
            return;
            case 7:
            this.UpdateCatalog = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\View\avtorizaciya.xaml"
            this.UpdateCatalog.Click += new System.Windows.RoutedEventHandler(this.Enter);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
