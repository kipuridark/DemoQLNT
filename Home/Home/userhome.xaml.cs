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
    public partial class userhome : ContentPage
    {
        public userhome()
        {
            InitializeComponent();
        }

        private void cmdDangxuat_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Loginuser());
        }

        private void cmdXemthongbao_Clicked(object sender, EventArgs e)
        {

        }

        private void cmdKbyt_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new kbyt());
        }

        private void cmdHoadon_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bills());
        }

        private void cmdInfor_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new infor());
        }
    }
}