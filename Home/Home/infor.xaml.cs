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
    public partial class infor : ContentPage
    {
        public infor()
        {
            InitializeComponent();
        }

        private void cmdCapnhat_Clicked(object sender, EventArgs e)
        {
            if (txtName.Text==null||txtId.Text==null||txtMail.Text==null||txtPhone.Text==null||txtAddr.Text==null)
            {
                DisplayAlert("Thông báo","Bạn nhập thiếu thông tin. \n Vui lòng kiểm tra lại và nhập đầy đủ thông tin cần thiết!","OK");
            }
            else
            {
                DisplayAlert("Thông báo", "Bạn đã cập nhật thành công thông tin cá nhân!", "OK");
            }
        }
    }
}