using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd7_V5_ChubarkovMatvey
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		int priceHouse;
		public Page2 (string name, int price, int rooms, string owner, string adress, string desc, string image)
		{
			InitializeComponent ();

			nameLabel.Text = "Название : " + name;
			priceLabel.Text = "Цена : " + price.ToString () + "$";
			priceHouse = price;
			roomsLabel.Text = "Комнаты :" + rooms.ToString ();
			ownerLabel.Text = "Владелец : " + owner;
			adressLabel.Text = "Адресс : " + adress;
			descLabel.Text = "Описание : " + desc;
			imageLabel.Source = image;
		}

        private async void Calc(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1(priceHouse));
        }

        private async void Back(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new SwipePage());
        }
    }
}