﻿#pragma checksum "..\..\Reguistro.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64C5168E145BA73DD2B87384C780D4EEEBF3FECD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Principal;
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


namespace Principal {
    
    
    /// <summary>
    /// Reguistro
    /// </summary>
    public partial class Reguistro : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\Reguistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEmpleados;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Reguistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClientes;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Reguistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProductos;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Reguistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRegresar;
        
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
            System.Uri resourceLocater = new System.Uri("/Principal;component/reguistro.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Reguistro.xaml"
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
            this.btnEmpleados = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Reguistro.xaml"
            this.btnEmpleados.Click += new System.Windows.RoutedEventHandler(this.btnEmpleados_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnClientes = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Reguistro.xaml"
            this.btnClientes.Click += new System.Windows.RoutedEventHandler(this.btnClientes_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnProductos = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\Reguistro.xaml"
            this.btnProductos.Click += new System.Windows.RoutedEventHandler(this.btnProductos_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnRegresar = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\Reguistro.xaml"
            this.btnRegresar.Click += new System.Windows.RoutedEventHandler(this.btnRegresar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
