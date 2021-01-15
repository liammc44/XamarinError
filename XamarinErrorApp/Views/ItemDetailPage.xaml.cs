using System.ComponentModel;
using Xamarin.Forms;
using XamarinErrorApp.ViewModels;

namespace XamarinErrorApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}