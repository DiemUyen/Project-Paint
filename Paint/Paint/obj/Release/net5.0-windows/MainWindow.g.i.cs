﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8B189481B8CA8911A1E3C460C2026F5DA43E9C7D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Fluent;
using Paint;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Paint {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : Fluent.RibbonWindow, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 16 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnNew;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnOpen;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnSaveAsBinary;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnSaveAsPng;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnUndo;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnRedo;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnPaste;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnCut;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnCopy;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.DropDownButton DropdownBtnSize;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView SizeList;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.DropDownButton DropdownBtnStyle;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView StyleList;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ShapeList;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnBrushColor;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnEraserColor;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ColorList;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnColorPicker;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnZoomIn;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnZoomOut;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer ScrollBar;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvas;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border border;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Paint;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\MainWindow.xaml"
            ((Paint.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnNew = ((Fluent.Button)(target));
            
            #line 16 "..\..\..\MainWindow.xaml"
            this.BtnNew.Click += new System.Windows.RoutedEventHandler(this.BtnNew_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnOpen = ((Fluent.Button)(target));
            
            #line 17 "..\..\..\MainWindow.xaml"
            this.BtnOpen.Click += new System.Windows.RoutedEventHandler(this.BtnOpen_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnSaveAsBinary = ((Fluent.Button)(target));
            
            #line 18 "..\..\..\MainWindow.xaml"
            this.BtnSaveAsBinary.Click += new System.Windows.RoutedEventHandler(this.BtnSaveAsBinary_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnSaveAsPng = ((Fluent.Button)(target));
            
            #line 19 "..\..\..\MainWindow.xaml"
            this.BtnSaveAsPng.Click += new System.Windows.RoutedEventHandler(this.BtnSaveAsPng_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnUndo = ((Fluent.Button)(target));
            
            #line 26 "..\..\..\MainWindow.xaml"
            this.BtnUndo.Click += new System.Windows.RoutedEventHandler(this.BtnUndo_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnRedo = ((Fluent.Button)(target));
            
            #line 34 "..\..\..\MainWindow.xaml"
            this.BtnRedo.Click += new System.Windows.RoutedEventHandler(this.BtnRedo_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnPaste = ((Fluent.Button)(target));
            
            #line 44 "..\..\..\MainWindow.xaml"
            this.BtnPaste.Click += new System.Windows.RoutedEventHandler(this.BtnPaste_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnCut = ((Fluent.Button)(target));
            
            #line 50 "..\..\..\MainWindow.xaml"
            this.BtnCut.Click += new System.Windows.RoutedEventHandler(this.BtnCut_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BtnCopy = ((Fluent.Button)(target));
            
            #line 56 "..\..\..\MainWindow.xaml"
            this.BtnCopy.Click += new System.Windows.RoutedEventHandler(this.BtnCopy_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.DropdownBtnSize = ((Fluent.DropDownButton)(target));
            return;
            case 12:
            this.SizeList = ((System.Windows.Controls.ListView)(target));
            return;
            case 14:
            this.DropdownBtnStyle = ((Fluent.DropDownButton)(target));
            return;
            case 15:
            this.StyleList = ((System.Windows.Controls.ListView)(target));
            return;
            case 17:
            this.ShapeList = ((System.Windows.Controls.ListView)(target));
            return;
            case 19:
            this.BtnBrushColor = ((Fluent.Button)(target));
            
            #line 118 "..\..\..\MainWindow.xaml"
            this.BtnBrushColor.Click += new System.Windows.RoutedEventHandler(this.BtnBrushColor_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            this.BtnEraserColor = ((Fluent.Button)(target));
            
            #line 119 "..\..\..\MainWindow.xaml"
            this.BtnEraserColor.Click += new System.Windows.RoutedEventHandler(this.BtnEraserColor_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            this.ColorList = ((System.Windows.Controls.ListView)(target));
            return;
            case 23:
            this.BtnColorPicker = ((Fluent.Button)(target));
            
            #line 135 "..\..\..\MainWindow.xaml"
            this.BtnColorPicker.Click += new System.Windows.RoutedEventHandler(this.BtnColorPicker_Click);
            
            #line default
            #line hidden
            return;
            case 24:
            this.BtnZoomIn = ((Fluent.Button)(target));
            
            #line 145 "..\..\..\MainWindow.xaml"
            this.BtnZoomIn.Click += new System.Windows.RoutedEventHandler(this.BtnZoomIn_Click);
            
            #line default
            #line hidden
            return;
            case 25:
            this.BtnZoomOut = ((Fluent.Button)(target));
            
            #line 151 "..\..\..\MainWindow.xaml"
            this.BtnZoomOut.Click += new System.Windows.RoutedEventHandler(this.BtnZoomOut_Click);
            
            #line default
            #line hidden
            return;
            case 26:
            this.ScrollBar = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 27:
            this.canvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 28:
            this.border = ((System.Windows.Controls.Border)(target));
            
            #line 163 "..\..\..\MainWindow.xaml"
            this.border.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            
            #line 163 "..\..\..\MainWindow.xaml"
            this.border.MouseMove += new System.Windows.Input.MouseEventHandler(this.Border_MouseMove);
            
            #line default
            #line hidden
            
            #line 163 "..\..\..\MainWindow.xaml"
            this.border.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 13:
            
            #line 76 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnSize_Click);
            
            #line default
            #line hidden
            break;
            case 16:
            
            #line 88 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnStyle_Click);
            
            #line default
            #line hidden
            break;
            case 18:
            
            #line 107 "..\..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnShape_Click);
            
            #line default
            #line hidden
            break;
            case 22:
            
            #line 130 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnColor_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

