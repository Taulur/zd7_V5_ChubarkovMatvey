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
	public partial class SwipePage : CarouselPage
	{
		public SwipePage ()
		{
			InitializeComponent ();
            Children.Add(new MainPage());
            Children.Add(new Page3());
            
        }
	}
}