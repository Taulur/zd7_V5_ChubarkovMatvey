using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace zd7_V5_ChubarkovMatvey
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void loginButton_Clicked(object sender, EventArgs e)
        {
           if (usernameEntry.Text == "ects" && passwordEntry.Text == "ects2024")
            {
                DisplayAlert("Авторитизация", "Вы успешно вошли", "ОK");
            }
           else
            {
                DisplayAlert("Авторитизация", "Неверный ввод данных", "ОK");
            }
        }
    }
}
