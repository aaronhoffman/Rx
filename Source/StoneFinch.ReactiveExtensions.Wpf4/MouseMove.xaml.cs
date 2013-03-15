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

            ////// Observable from Event
            ////// Project eventArgs to data we actually want
            ////var mousedown =
            ////    from evt in Observable.FromEventPattern<MouseButtonEventArgs>(this, "MouseDown")
            ////    select evt.EventArgs.GetPosition(this);

            ////var mouseup =
            ////    from evt in Observable.FromEventPattern<MouseButtonEventArgs>(this, "MouseUp")
            ////    select evt.EventArgs.GetPosition(this);

            ////var mousemove =
            ////    from evt in Observable.FromEventPattern<MouseEventArgs>(this, "MouseMove")
            ////    select evt.EventArgs.GetPosition(this);

            ////// start at a given Point - Observe until second observable "pushes"
            ////var mousedownmove =
            ////    from start in mousedown
            ////    from pos in mousemove.StartWith(start).TakeUntil(mouseup)
            ////    select pos;


            ////mousedown.ObserveOnDispatcher().Subscribe(x => this.MouseDownTextBlock.Text = x.ToString());
            ////mousedown.ObserveOnDispatcher().Subscribe(_ => this.MouseDownRect.Visibility = Visibility.Visible);

            ////mouseup.ObserveOnDispatcher().Subscribe(x => this.MouseUpTextBlock.Text = x.ToString());
            ////mouseup.ObserveOnDispatcher().Subscribe(_ => this.MouseDownRect.Visibility = Visibility.Hidden);

            ////mousemove.ObserveOnDispatcher().Subscribe(x => this.MouseMoveTextBlock.Text = x.ToString());

            ////mousedownmove.ObserveOnDispatcher().Subscribe(x => this.MouseDownMoveTextBlock.Text = x.ToString());


        }


        private void mouse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Modifying state
            this.IsMouseLeftButtonDown = true;

            // interrogate parameter to get desired value
            this.MouseDownTextBlock.Text = e.GetPosition(this).ToString();

            // unrelated logic
            this.MouseDownRect.Visibility = Visibility.Visible;
        }

        private void mouse_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.IsMouseLeftButtonDown = false;

            this.MouseUpTextBlock.Text = e.GetPosition(this).ToString();

            this.MouseDownRect.Visibility = Visibility.Hidden;
        }

        private void Window_MouseMove_1(object sender, MouseEventArgs e)
        {
            this.MouseMoveTextBlock.Text = e.GetPosition(this).ToString();

            // filter within event listener
            // unrelated logic
            if (this.IsMouseLeftButtonDown)
            {
                this.MouseDownMoveTextBlock.Text = e.GetPosition(this).ToString();
            }
        }


    }
}
