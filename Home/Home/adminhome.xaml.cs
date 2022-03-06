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
    public partial class adminhome : ContentPage
    {
        public adminhome()
        {
            InitializeComponent();
        }

        private void cmdDangxuat_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void cmdThongbao_Clicked(object sender, EventArgs e)
        {

        }

        private void cmdQuanly_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Dsphong());
        }
    }
}