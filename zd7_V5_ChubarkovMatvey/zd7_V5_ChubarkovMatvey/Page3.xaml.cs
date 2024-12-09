using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd7_V5_ChubarkovMatvey
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
    {
		public Page3 ()
		{
			InitializeComponent ();

            dateLabel.Text = DateTime.Today.ToString();


          
        }

        private async void More1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2("Пентхаус",17500000,9,"Павлов А.Д.","Горького 3Д","Один из самых престижных домов","house1"));
        }

        private async void Calc1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1(17500000));
        }
        private async void More2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2("Мегахаус", 22000000, 7, "Петрова М.К.", "Третьяково 8", "Самый технологичный дом!", "house2"));
        }

        private async void Calc2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1(22000000));
        }
        private async void More3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2("Нотбигхаус", 9000000, 5, "Валерьев Д.Е.", "Васькино 4", "Средний дом богатого человека", "house3"));
        }

        private async void Calc3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1(9000000));
        }
    }
}