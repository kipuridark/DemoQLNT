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
    public partial class Loginuser : ContentPage
    {
        public Loginuser()
        {
            InitializeComponent();
        }

        private void cmdLogin_Clicked(object sender, EventArgs e)
        {
            if (txtUsername.Text =="user"&&txtPassword.Text=="123")
            {
                Navigation.PushAsync(new userhome());
            }
            else if(txtUsername.Text == null || txtPassword.Text == null)
            {
                DisplayAlert("Thông báo","Bạn nhập thiếu tên đăng nhập hoặc mật khẩu.\nVui lòng nhập đầy đủ!","OK");
            }   
            else 
            {
                DisplayAlert("Thông báo","Tên đăng nhập hoặc mật khẩu sai! \n Vui lòng nhập lại!","OK");
            }
        }

        private void cmdLoginadmin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void cmdSignup_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new signup());
        }
    }
}