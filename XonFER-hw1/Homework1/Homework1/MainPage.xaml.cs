using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework1.ViewModel;
using Xamarin.Forms;

namespace Homework1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		    BindingContext = new ColorViewModel();
        }
    }
}
