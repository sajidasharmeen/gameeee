using System;
using System.Collections.Generic;
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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace game
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        int count=0;
        private void cat_tapped(object sender, TappedRoutedEventArgs e)
        {

            if (cato.IsTapEnabled)
            {





                count += 10;

                cat_ka.Visibility = Windows.UI.Xaml.Visibility.Collapsed;


                cato.Source = null;


                cc.Text = Convert.ToString(count);

                Storyboard1.Begin();




            }


          

        }

        private void wall_tapped(object sender, TappedRoutedEventArgs e)
        {



            if (wall.IsTapEnabled)
            {





                count += 10;

                wallet_ka.Content = null;

                wall.Source = null;


                wa.Text = Convert.ToString(count);

                //abc.Source = "";
                //abc.Play();

            }


          

        }

        private void app_tapped(object sender, TappedRoutedEventArgs e)
        {

            if (apple.IsTapEnabled)
            {





                count += 10;

                app_ka.Content = null;

                apple.Source = null;


                ss.Text = Convert.ToString(count);

                Storyboard2.Begin();



            }

        }
    }
}
