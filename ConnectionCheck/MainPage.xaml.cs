using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ConnectionCheck
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void BtnCheck_Clicked(object sender, EventArgs e)
		{
			label.Text = Connectivity.NetworkAccess == NetworkAccess.Internet
							? "Internet connection available!"
							: "No Internet connection";
		}
	}
}