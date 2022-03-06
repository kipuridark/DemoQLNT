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
    public partial class Dsphong : ContentPage
    {
        List<Phong> phongList;

        void PhongInit()
        {
            phongList = new List<Phong>();
            phongList.Add(new Phong() { phongId = "Phòng 1", phongImg = "tro1.jpg"});
            phongList.Add(new Phong() { phongId = "Phòng 2", phongImg = "tro2.jpg" });
            phongList.Add(new Phong() { phongId = "Phòng 3", phongImg = "tro3.png" });

            lstPhong.ItemsSource = phongList;
        }

        public Dsphong()
        {
            InitializeComponent();

            PhongInit();
        }
    }
}