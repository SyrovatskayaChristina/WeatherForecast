using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace weatherForecaster2
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : MasterDetailPage
	{
		public MainPage()
		{
			InitializeComponent();

			Detail = new NavigationPage(new Page1());
			IsPresented = true;

			

		}
		public void ButtonClickSpb(object sender, EventArgs e)
		{
			Detail = new NavigationPage(new Page1()); 
			IsPresented = false;
		}

		public void ButtonClickMsc(object sender, EventArgs e)
		{
			Detail = new NavigationPage(new Page2());
			IsPresented = false;
		}
		public void ButtonClickMrm(object sender, EventArgs e)
		{
			Detail = new NavigationPage(new Mrm());
			IsPresented = false;
		}
		public void ButtonClickEkb(object sender, EventArgs e)
		{
			Detail = new NavigationPage(new Ekb());
			IsPresented = false;
		}

		//public void ButtonClickSmr(object sender, EventArgs e)
		//{
		//	Detail = new NavigationPage(new Page1());
		//}
		//public void ButtonClickTula(object sender, EventArgs e)
		//{
		//	Detail = new NavigationPage(new Page1());
		//}

	}
}
