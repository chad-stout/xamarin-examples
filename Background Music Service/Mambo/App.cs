using System;
using Xamarin.Forms;

namespace Mambo
{
	public class Mambo
	{
		public Button RestartButton {get;set;}

		public Page MamboPage 
		{
			get
			{	
				return new ContentPage { 
					Content = RestartButton
				};
			}
		}

		public Mambo()
		{
			RestartButton = new Button {
				Text = "Go on, you know you wanna press me."
			};
		}
	}
}

