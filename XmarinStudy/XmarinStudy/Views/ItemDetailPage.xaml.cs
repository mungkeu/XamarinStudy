using System.ComponentModel;
using Xamarin.Forms;
using XmarinStudy.ViewModels;

namespace XmarinStudy.Views
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