using System;
using System.Collections.Generic;
using XamarinErrorApp.ViewModels;
using XamarinErrorApp.Views;
using Xamarin.Forms;

namespace XamarinErrorApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
