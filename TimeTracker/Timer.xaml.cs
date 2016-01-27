using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TimeTracker
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Timer : Page
    {
        public Timer()
        {
            this.InitializeComponent();

        }

        private void ellipse_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Storyboard myStoryboard;
            Debug.WriteLine("In Tapped Event");
            myStoryboard = (Storyboard)this.Resources["GoButton"];
            myStoryboard.Begin();
            ellipse.IsTapEnabled = false;
            textBlock.IsTapEnabled = false;
        }

        private void textBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Storyboard myStoryboard;
            Debug.WriteLine("In Text Block Tapped Event");
            myStoryboard = (Storyboard)this.Resources["GoButton"];
            myStoryboard.Begin();
            textBlock.IsTapEnabled = false;
            ellipse.IsTapEnabled = false;
        }
    }
}
