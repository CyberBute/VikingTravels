﻿#pragma checksum "..\..\JourUpdate.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9B750168680E49E2B7E54534F829061E81F8798057DD46B88C2806F401ECD0F1"
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
using VikingTravelsExam;


namespace VikingTravelsExam {
    
    
    /// <summary>
    /// JourUpdate
    /// </summary>
    public partial class JourUpdate : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\JourUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox insertTitle;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\JourUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox insertCity;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\JourUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker insertStartDate;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\JourUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker insertEndDate;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\JourUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox insertMax;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\JourUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox insertCarrierNames;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\JourUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox insertPrice;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\JourUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox insertDic;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\JourUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updateJour;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\JourUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Chancel;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\JourUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label errorMessage;
        
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
            System.Uri resourceLocater = new System.Uri("/VikingTravelsExam;component/jourupdate.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\JourUpdate.xaml"
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
            this.insertTitle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.insertCity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.insertStartDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.insertEndDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.insertMax = ((System.Windows.Controls.TextBox)(target));
            
            #line 43 "..\..\JourUpdate.xaml"
            this.insertMax.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumbersOnly);
            
            #line default
            #line hidden
            return;
            case 6:
            this.insertCarrierNames = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.insertPrice = ((System.Windows.Controls.TextBox)(target));
            
            #line 51 "..\..\JourUpdate.xaml"
            this.insertPrice.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumbersOnly);
            
            #line default
            #line hidden
            return;
            case 8:
            this.insertDic = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.updateJour = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\JourUpdate.xaml"
            this.updateJour.Click += new System.Windows.RoutedEventHandler(this.UpdateJour_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Chancel = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\JourUpdate.xaml"
            this.Chancel.Click += new System.Windows.RoutedEventHandler(this.Chancel_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.errorMessage = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
