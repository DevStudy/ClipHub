﻿#pragma checksum "..\..\..\SelectMenu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "27F5F1FD0756E71F6511847AA6AD455A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ClipHub.Code.Helpers;
using ClipboardPro;
using Hardcodet.Wpf.TaskbarNotification;
using MahApps.Metro.Controls;
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


namespace ClipboardPro {
    
    
    /// <summary>
    /// SelectMenu
    /// </summary>
    public partial class SelectMenu : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 260 "..\..\..\SelectMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListClips;
        
        #line default
        #line hidden
        
        
        #line 281 "..\..\..\SelectMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearch;
        
        #line default
        #line hidden
        
        
        #line 289 "..\..\..\SelectMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup ListPopup;
        
        #line default
        #line hidden
        
        
        #line 298 "..\..\..\SelectMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PopupTxt;
        
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
            System.Uri resourceLocater = new System.Uri("/ClipHub;component/selectmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SelectMenu.xaml"
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
            
            #line 7 "..\..\..\SelectMenu.xaml"
            ((ClipboardPro.SelectMenu)(target)).PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.MetroWindow_PreviewKeyDown_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ListClips = ((System.Windows.Controls.ListView)(target));
            
            #line 260 "..\..\..\SelectMenu.xaml"
            this.ListClips.PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.ListClips_PreviewKeyDown_1);
            
            #line default
            #line hidden
            
            #line 261 "..\..\..\SelectMenu.xaml"
            this.ListClips.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ListView_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 262 "..\..\..\SelectMenu.xaml"
            this.ListClips.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListClips_SelectionChanged_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 281 "..\..\..\SelectMenu.xaml"
            this.txtSearch.PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.txtSearch_KeyDown_1);
            
            #line default
            #line hidden
            
            #line 284 "..\..\..\SelectMenu.xaml"
            this.txtSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSearch_TextChanged_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ListPopup = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 5:
            this.PopupTxt = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

