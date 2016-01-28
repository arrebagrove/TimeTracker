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
            Debug.WriteLine("In GoTapped Event");
            myStoryboard = (Storyboard)this.Resources["GoButtonTapped"];
            myStoryboard.Begin();
            GoEllipse.IsTapEnabled = false;
            StopEllipse.IsTapEnabled = true;
            
            StopTextBlock.IsTapEnabled = true;
        }

        private void PauseEllipse_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void StopEllipse_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Storyboard myStoryboard;
            Debug.WriteLine("In StopTapped Event");
            myStoryboard = (Storyboard)this.Resources["StopButtonPress"];
            myStoryboard.Begin();
            GoEllipse.IsTapEnabled = true;
            StopEllipse.IsTapEnabled = false;
            StopGrid.IsTapEnabled = false;
            StopTextBlock.IsTapEnabled = false;

        }

        private void StopTextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Storyboard myStoryboard;
            Debug.WriteLine("In Stop Text Tapped Event");
            myStoryboard = (Storyboard)this.Resources["StopButtonPress"];
            myStoryboard.Begin();
            GoEllipse.IsTapEnabled = true;
            StopEllipse.IsTapEnabled = false;
            StopGrid.IsTapEnabled = false;
            StopTextBlock.IsTapEnabled = false;
        }

        private void StopGrid_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Storyboard myStoryboard;
            Debug.WriteLine("In Stop Grid Tapped Event");
            myStoryboard = (Storyboard)this.Resources["StopButtonPress"];
            myStoryboard.Begin();
            GoEllipse.IsTapEnabled = true;
            StopEllipse.IsTapEnabled = false;
            StopGrid.IsTapEnabled = false;
            StopTextBlock.IsTapEnabled = false;
        }

        private void PauseGrid_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }
    }
}
