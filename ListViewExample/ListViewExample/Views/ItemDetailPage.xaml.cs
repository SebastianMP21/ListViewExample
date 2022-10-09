using ListViewExample.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ListViewExample.Views
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