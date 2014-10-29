using System;
using Xamarin.Forms;
using CustomRenderer.Forms.Custom;

namespace CustomRenderer.Forms
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new ContentPage { 
				Content = new MyEntry {
					Text = "Custom Rendered Entry",
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
				},
			};
		}
	}
}

