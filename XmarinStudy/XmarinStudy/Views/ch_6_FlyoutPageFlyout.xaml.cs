using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XmarinStudy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ch_6_FlyoutPageFlyout : ContentPage
    {
        public ListView ListView;

        public ch_6_FlyoutPageFlyout()
        {
            InitializeComponent();

            BindingContext = new ch_6_FlyoutPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class ch_6_FlyoutPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ch_6_FlyoutPageFlyoutMenuItem> MenuItems { get; set; }

            public ch_6_FlyoutPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<ch_6_FlyoutPageFlyoutMenuItem>(new[]
                {
                    new ch_6_FlyoutPageFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new ch_6_FlyoutPageFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new ch_6_FlyoutPageFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new ch_6_FlyoutPageFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new ch_6_FlyoutPageFlyoutMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}