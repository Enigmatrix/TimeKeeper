﻿#pragma checksum "..\..\..\Views\MainView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E928C5120B8DDCC79D7FD04FC5E353C3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
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
using System.Windows.Interactivity;
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
using TimeKeeper;
using TimeKeeper.Controls;
using TimeKeeper.Converters;
using TimeKeeper.ViewModels;


namespace TimeKeeper.Views {
    
    
    /// <summary>
    /// MainView
    /// </summary>
    public partial class MainView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ContentRoot;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TimeKeeper.Controls.ResetDurationControl Resetter;
        
        #line default
        #line hidden
        
        
        #line 182 "..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle ResizeNW;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle ResizeN;
        
        #line default
        #line hidden
        
        
        #line 188 "..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle ResizeNE;
        
        #line default
        #line hidden
        
        
        #line 191 "..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle ResizeE;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle ResizeSE;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle ResizeS;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle ResizeSW;
        
        #line default
        #line hidden
        
        
        #line 203 "..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle ResizeW;
        
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
            System.Uri resourceLocater = new System.Uri("/TimeKeeper;component/views/mainview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MainView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 10 "..\..\..\Views\MainView.xaml"
            ((TimeKeeper.Views.MainView)(target)).SourceInitialized += new System.EventHandler(this.MainWindowSourceInitialized);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.ContentRoot = ((System.Windows.Controls.Border)(target));
            
            #line 44 "..\..\..\Views\MainView.xaml"
            this.ContentRoot.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MoveWindow);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Resetter = ((TimeKeeper.Controls.ResetDurationControl)(target));
            return;
            case 5:
            this.ResizeNW = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 181 "..\..\..\Views\MainView.xaml"
            this.ResizeNW.MouseEnter += new System.Windows.Input.MouseEventHandler(this.DisplayResizeCursor);
            
            #line default
            #line hidden
            
            #line 182 "..\..\..\Views\MainView.xaml"
            this.ResizeNW.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ResetCursor);
            
            #line default
            #line hidden
            
            #line 182 "..\..\..\Views\MainView.xaml"
            this.ResizeNW.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Resize);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ResizeN = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 184 "..\..\..\Views\MainView.xaml"
            this.ResizeN.MouseEnter += new System.Windows.Input.MouseEventHandler(this.DisplayResizeCursor);
            
            #line default
            #line hidden
            
            #line 185 "..\..\..\Views\MainView.xaml"
            this.ResizeN.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ResetCursor);
            
            #line default
            #line hidden
            
            #line 185 "..\..\..\Views\MainView.xaml"
            this.ResizeN.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Resize);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ResizeNE = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 187 "..\..\..\Views\MainView.xaml"
            this.ResizeNE.MouseEnter += new System.Windows.Input.MouseEventHandler(this.DisplayResizeCursor);
            
            #line default
            #line hidden
            
            #line 188 "..\..\..\Views\MainView.xaml"
            this.ResizeNE.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ResetCursor);
            
            #line default
            #line hidden
            
            #line 188 "..\..\..\Views\MainView.xaml"
            this.ResizeNE.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Resize);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ResizeE = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 190 "..\..\..\Views\MainView.xaml"
            this.ResizeE.MouseEnter += new System.Windows.Input.MouseEventHandler(this.DisplayResizeCursor);
            
            #line default
            #line hidden
            
            #line 191 "..\..\..\Views\MainView.xaml"
            this.ResizeE.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ResetCursor);
            
            #line default
            #line hidden
            
            #line 191 "..\..\..\Views\MainView.xaml"
            this.ResizeE.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Resize);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ResizeSE = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 193 "..\..\..\Views\MainView.xaml"
            this.ResizeSE.MouseEnter += new System.Windows.Input.MouseEventHandler(this.DisplayResizeCursor);
            
            #line default
            #line hidden
            
            #line 194 "..\..\..\Views\MainView.xaml"
            this.ResizeSE.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ResetCursor);
            
            #line default
            #line hidden
            
            #line 194 "..\..\..\Views\MainView.xaml"
            this.ResizeSE.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Resize);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ResizeS = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 196 "..\..\..\Views\MainView.xaml"
            this.ResizeS.MouseEnter += new System.Windows.Input.MouseEventHandler(this.DisplayResizeCursor);
            
            #line default
            #line hidden
            
            #line 197 "..\..\..\Views\MainView.xaml"
            this.ResizeS.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ResetCursor);
            
            #line default
            #line hidden
            
            #line 197 "..\..\..\Views\MainView.xaml"
            this.ResizeS.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Resize);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ResizeSW = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 199 "..\..\..\Views\MainView.xaml"
            this.ResizeSW.MouseEnter += new System.Windows.Input.MouseEventHandler(this.DisplayResizeCursor);
            
            #line default
            #line hidden
            
            #line 200 "..\..\..\Views\MainView.xaml"
            this.ResizeSW.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ResetCursor);
            
            #line default
            #line hidden
            
            #line 200 "..\..\..\Views\MainView.xaml"
            this.ResizeSW.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Resize);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ResizeW = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 202 "..\..\..\Views\MainView.xaml"
            this.ResizeW.MouseEnter += new System.Windows.Input.MouseEventHandler(this.DisplayResizeCursor);
            
            #line default
            #line hidden
            
            #line 203 "..\..\..\Views\MainView.xaml"
            this.ResizeW.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ResetCursor);
            
            #line default
            #line hidden
            
            #line 203 "..\..\..\Views\MainView.xaml"
            this.ResizeW.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Resize);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
