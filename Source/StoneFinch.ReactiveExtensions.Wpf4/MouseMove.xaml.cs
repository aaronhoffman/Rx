using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StoneFinch.ReactiveExtensions.Wpf4
{
    /// <summary>
    /// Interaction logic for MouseMove.xaml
    /// </summary>
    public partial class MouseMove : Window
    {
        private bool IsMouseLeftButtonDown = false;

        public MouseMove()
        {
            InitializeComponent();


            ////var mousedown =
            ////    from evt in Observable.FromEventPattern<MouseButtonEventArgs>(this, "MouseDown")
            ////    select evt.EventArgs.GetPosition(this);

            ////var mouseup =
            ////    from evt in Observable.FromEventPattern<MouseButtonEventArgs>(this, "MouseUp")
            ////    select evt.EventArgs.GetPosition(this);

            ////var mousemove =
            ////    from evt in Observable.FromEventPattern<MouseEventArgs>(this, "MouseMove")
            ////    select evt.EventArgs.GetPosition(this);


            ////var obs =
            ////    from start in mousedown
            ////    from pos in mousemove.StartWith(start).TakeUntil(mouseup)
            ////    select pos;

            ////obs.ObserveOnDispatcher().Subscribe(x => this.MouseCoordsTextBlock.Text = x.ToString());
        }


        private void mouse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.IsMouseLeftButtonDown = true;
        }

        private void mouse_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.IsMouseLeftButtonDown = false;
        }

        private void Window_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (this.IsMouseLeftButtonDown)
            {
                this.MouseCoordsTextBlock.Text = e.GetPosition(this).ToString();
            }
        }


    }
}
