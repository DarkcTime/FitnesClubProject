﻿#pragma checksum "..\..\..\..\..\View\Administrator\Subscriptions\DialogWindowSelectClient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CFF466F3D7853E11B45CEFA1737EE027A3BFCBC2420A6F380E3A953E09C59E9E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FitnesClub.View.Administrator.Subscriptions;
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


namespace FitnesClub.View.Administrator.Subscriptions {
    
    
    /// <summary>
    /// DialogWindowSelectClient
    /// </summary>
    public partial class DialogWindowSelectClient : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\..\View\Administrator\Subscriptions\DialogWindowSelectClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup PopupListClient;
        
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
            System.Uri resourceLocater = new System.Uri("/FitnesClub;component/view/administrator/subscriptions/dialogwindowselectclient.x" +
                    "aml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Administrator\Subscriptions\DialogWindowSelectClient.xaml"
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
            
            #line 24 "..\..\..\..\..\View\Administrator\Subscriptions\DialogWindowSelectClient.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.TextBlock_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PopupListClient = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
