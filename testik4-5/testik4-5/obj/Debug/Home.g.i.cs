﻿#pragma checksum "..\..\Home.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C68002DCCC61D96F3FBD4719165DAFA055F5D1FDE5286034651D8D22C1C9011C"
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
using testik4_5;


namespace testik4_5 {
    
    
    /// <summary>
    /// Home
    /// </summary>
    public partial class Home : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListFlowers;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ToolsListEdit;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Search;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckRoses;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckTulips;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckLilies;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckGypsophiles;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckPeonies;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PriceDipBox;
        
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
            System.Uri resourceLocater = new System.Uri("/testik4-5;component/home.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Home.xaml"
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
            this.ListFlowers = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.ToolsListEdit = ((System.Windows.Controls.ListView)(target));
            
            #line 43 "..\..\Home.xaml"
            this.ToolsListEdit.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ToolsListEdit_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Search = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.CheckRoses = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.CheckTulips = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.CheckLilies = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.CheckGypsophiles = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.CheckPeonies = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 9:
            this.PriceDipBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 116 "..\..\Home.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

