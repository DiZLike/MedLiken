﻿#pragma checksum "..\..\..\..\GUI\MainWnd.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "29A132C91BECC7CAF280E516B1BA06EE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.1
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


namespace MedLiken.GUI {
    
    
    /// <summary>
    /// MainWnd
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class MainWnd : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\GUI\MainWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMd;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\GUI\MainWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label mv;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\GUI\MainWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lPlatform;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\GUI\MainWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView gl;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\GUI\MainWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStart;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MedLiken;component/gui/mainwnd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\GUI\MainWnd.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 17 "..\..\..\..\GUI\MainWnd.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnGamesDit);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 19 "..\..\..\..\GUI\MainWnd.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnVideo);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 20 "..\..\..\..\GUI\MainWnd.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnAudio);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 21 "..\..\..\..\GUI\MainWnd.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnNetPlay);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 23 "..\..\..\..\GUI\MainWnd.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnMD);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnMd = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\GUI\MainWnd.xaml"
            this.btnMd.Click += new System.Windows.RoutedEventHandler(this.btnMd_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.mv = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lPlatform = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.gl = ((System.Windows.Controls.ListView)(target));
            return;
            case 10:
            this.btnStart = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\..\GUI\MainWnd.xaml"
            this.btnStart.Click += new System.Windows.RoutedEventHandler(this.btnStart_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

