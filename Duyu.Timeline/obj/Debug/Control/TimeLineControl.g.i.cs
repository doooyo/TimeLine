﻿#pragma checksum "C:\Users\yu\Desktop\Sobey.TimeLine\Duyu.Timeline\Control\TimeLineControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CE7E83125FCF74F2711138E40D81797C"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.33440
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Duyu.Timeline.Control {
    
    
    public partial class TimeLineControl : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.ScrollViewer sv_Main;
        
        internal System.Windows.Controls.Grid ItemContainer;
        
        internal System.Windows.Controls.Grid TopMoreContainer;
        
        internal System.Windows.Controls.Button TopMore;
        
        internal System.Windows.Controls.ItemsControl tc_Items;
        
        internal System.Windows.Controls.Grid BottomMoreContainer;
        
        internal System.Windows.Controls.Button BottomMore;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Duyu.Timeline;component/Control/TimeLineControl.xaml", System.UriKind.Relative));
            this.sv_Main = ((System.Windows.Controls.ScrollViewer)(this.FindName("sv_Main")));
            this.ItemContainer = ((System.Windows.Controls.Grid)(this.FindName("ItemContainer")));
            this.TopMoreContainer = ((System.Windows.Controls.Grid)(this.FindName("TopMoreContainer")));
            this.TopMore = ((System.Windows.Controls.Button)(this.FindName("TopMore")));
            this.tc_Items = ((System.Windows.Controls.ItemsControl)(this.FindName("tc_Items")));
            this.BottomMoreContainer = ((System.Windows.Controls.Grid)(this.FindName("BottomMoreContainer")));
            this.BottomMore = ((System.Windows.Controls.Button)(this.FindName("BottomMore")));
        }
    }
}

