using ePrdaja.Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ePrdaja.Mobile.Views
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