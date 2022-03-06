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
    public partial class signup : ContentPage
    {
        public signup()
        {
            InitializeComponent();
        }

        private void cmdSignup_Clicked(object sender, EventArgs e)
        {
            if (txtUsername.Text == null || txtEmail.Text== null || txtPassword.Text== null || txtCfpassword.Text== null)
            {
                DisplayAlert("Thông báo", "Bạn đã nhập thiếu thông tin. \nYêu cầu nhập đầy đủ thông tin!", "OK");
            } else if (txtPassword.Text!=txtCfpassword.Text)
            {
                DisplayAlert("Thông báo", "Mật khẩu bạn nhập không trùng khớp nhau. \nYêu cầu nhập lại mật khẩu!", "OK");
            } else
            {
                DisplayAlert("Thông báo", "Bạn đã đăng ký thành công!", "OK");
            }
        }

        private void cmdReturn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Loginuser());
        }
    }
}