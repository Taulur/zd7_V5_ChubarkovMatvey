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
	public partial class Page1 : ContentPage
	{
        int priceHouse;
		public Page1(int price)
		{
			InitializeComponent ();
			priceHouse = price;
            priceEntry.Text = price.ToString();
		}

        private void OnPaymentTypeChanged(object sender, EventArgs e)
        {
            
        }

        private void OnCalculateClicked(object sender, EventArgs e)
        {
            if (
                int.TryParse(paymentTermEntry.Text, out int term) && paymentTypePicker.SelectedItem != null && Convert.ToInt32( paymentTermEntry.Text) >= 1 && Convert.ToInt32(paymentTermEntry.Text) <= 10)
            {
                decimal finalPrice = Convert.ToDecimal(priceHouse);

              
                if (paymentTypePicker.SelectedIndex == 0) 
                {
                    finalPrice *= 0.9m; 
                }
                else if (paymentTypePicker.SelectedIndex == 1) 
                {
                    finalPrice *= 1.1m; 
                }

             
                if (term >= 1 && term <= 4)
                {
                    finalPrice *= 1.05m; 
                }
                else if (term >= 5 && term <= 10)
                {
                    finalPrice *= 1.1m; 
                }
                else if (term >= 11 && term <= 20)
                {
                    finalPrice *= 1.15m; 
                }

                resultLabel.Text = $"Итоговая сумма: {finalPrice:C}";
            }
            else
            {
                resultLabel.Text = "Пожалуйста, введите корректные значения.";
            }
        }
    }
}