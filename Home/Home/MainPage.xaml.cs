using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Home
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void cmdLogin_Clicked(object sender, EventArgs e)
        {
            if (txtUsername.Text=="admin"&&txtPassword.Text=="admin")
            {
                Navigation.PushAsync(new adminhome());
            }else if (txtUsername.Text == null || txtPassword.Text == null)
            {
                DisplayAlert("Thông báo", "Bạn nhập thiếu tên đăng nhập hoặc mật khẩu.\nVui lòng nhập đầy đủ!", "OK");
            }   
            else 
            {
                DisplayAlert("Thông báo", "Tên đăng nhập hoặc mật khẩu sai! Vui lòng nhập lại", "OK");
            }
              
        }

        private void cmdLoginuser_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Loginuser());
        }
    }
}
