using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bills : ContentPage
    {
        public Bills()
        {
            InitializeComponent();
        }

        private void cmdThanhtoan_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Thông báo","Bạn đã thanh toán thành công!","OK");
            Navigation.PushAsync(new userhome());
        }
    }
}