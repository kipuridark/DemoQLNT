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
    public partial class kbyt : ContentPage
    {
        public kbyt()
        {
            InitializeComponent();
        }

        private void cmdKhaibao_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Thông báo","Bạn đã khai báo y tế thành công!","OK");
            Navigation.PushAsync(new userhome());
        }
    }
}