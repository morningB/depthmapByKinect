﻿#pragma checksum "..\..\KinectWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D16158A8625FDF89E8A40CDCE77D347DB5BD2DA71ACD5E80A61208FBA34CD97D"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Samples.Kinect.KinectExplorer;
using Microsoft.Samples.Kinect.WpfViewers;
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


namespace Microsoft.Samples.Kinect.KinectExplorer {
    
    
    /// <summary>
    /// KinectWindow
    /// </summary>
    public partial class KinectWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\KinectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid layoutGrid;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\KinectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainViewerHost;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\KinectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ColorVis;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\KinectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Samples.Kinect.WpfViewers.KinectColorViewer ColorViewer;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\KinectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Samples.Kinect.WpfViewers.KinectAudioViewer kinectAudioViewer;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\KinectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SideViewerHost;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\KinectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid DepthVis;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\KinectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Samples.Kinect.WpfViewers.KinectDepthViewer DepthViewer;
        
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
            System.Uri resourceLocater = new System.Uri("/KinectExplorer-WPF;component/kinectwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\KinectWindow.xaml"
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
            
            #line 16 "..\..\KinectWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Swap_Executed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.layoutGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.MainViewerHost = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.ColorVis = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.ColorViewer = ((Microsoft.Samples.Kinect.WpfViewers.KinectColorViewer)(target));
            return;
            case 6:
            this.kinectAudioViewer = ((Microsoft.Samples.Kinect.WpfViewers.KinectAudioViewer)(target));
            return;
            case 7:
            this.SideViewerHost = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.DepthVis = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.DepthViewer = ((Microsoft.Samples.Kinect.WpfViewers.KinectDepthViewer)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

