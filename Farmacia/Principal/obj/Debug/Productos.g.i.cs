﻿#pragma checksum "..\..\Productos.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "088C6EE92DB3EC855C1C00047478654904A05000"
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
    /// Productos
    /// </summary>
    public partial class Productos : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\Productos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRegresar;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Productos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgProductos;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Productos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxNombreCategoria;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Productos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxNombreProducto;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Productos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxCantidad;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Productos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxDescipcion;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Productos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxPresentacion;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Productos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxPresioCompra;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\Productos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxPresioVenta;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\Productos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAgregarProducto;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\Productos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditarProducto;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\Productos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminarProducto;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\Productos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGuardar;
        
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
            System.Uri resourceLocater = new System.Uri("/Principal;component/productos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Productos.xaml"
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
            this.btnRegresar = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Productos.xaml"
            this.btnRegresar.Click += new System.Windows.RoutedEventHandler(this.btnRegresar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dtgProductos = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.tbxNombreCategoria = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbxNombreProducto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbxCantidad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbxDescipcion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbxPresentacion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tbxPresioCompra = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.tbxPresioVenta = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.btnAgregarProducto = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\Productos.xaml"
            this.btnAgregarProducto.Click += new System.Windows.RoutedEventHandler(this.btnAgregarProducto_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnEditarProducto = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\Productos.xaml"
            this.btnEditarProducto.Click += new System.Windows.RoutedEventHandler(this.btnEditarProducto_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnEliminarProducto = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\Productos.xaml"
            this.btnEliminarProducto.Click += new System.Windows.RoutedEventHandler(this.btnEliminarProducto_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btnGuardar = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\Productos.xaml"
            this.btnGuardar.Click += new System.Windows.RoutedEventHandler(this.btnGuardar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

