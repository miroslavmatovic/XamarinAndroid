using System.ComponentModel;
using Xamarin.Forms;
using XamarinAndroid.ViewModels;

namespace XamarinAndroid.Views
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