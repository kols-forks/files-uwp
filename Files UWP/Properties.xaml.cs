using Files.Filesystem;
using Files.Interacts;
using Files.Navigation;
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

namespace Files
{

    public sealed partial class Properties : Page
    {
        public Properties()
        {
            this.InitializeComponent();

        }

        protected override void OnNavigatedTo(NavigationEventArgs eventArgs)
        {
            base.OnNavigatedTo(eventArgs);
            //var selectedItemsAsParameter = eventArgs.Parameter as List<ListedItem>;
            //if (selectedItemsAsParameter.Count > 1)
            //{


            //    if (selectedItemsAsParameter.Any(x => x.FileType != selectedItemsAsParameter[0].FileType)) { itemType.Text = "Various types"; }
            //    else { itemType.Text = selectedItemsAsParameter[0].FileType; }

            //    if(ItemViewModel<ProHome>.GetCurrentSelectedTabInstance<ProHome>().accessibleContentFrame.SourcePageType == typeof(GenericFileBrowser))
            //    {
            //        itemPath.Text = "All within " + (ItemViewModel<ProHome>.GetCurrentSelectedTabInstance<ProHome>().accessibleContentFrame.Content as GenericFileBrowser).instanceViewModel.Universal.path;
            //    }
            //    else if (ItemViewModel<ProHome>.GetCurrentSelectedTabInstance<ProHome>().accessibleContentFrame.SourcePageType == typeof(PhotoAlbum))
            //    {
            //        itemPath.Text = "All within " + (ItemViewModel<ProHome>.GetCurrentSelectedTabInstance<ProHome>().accessibleContentFrame.Content as PhotoAlbum).instanceViewModel.Universal.path;
            //    }

            //}
        }

        private void OK_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Apply_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
