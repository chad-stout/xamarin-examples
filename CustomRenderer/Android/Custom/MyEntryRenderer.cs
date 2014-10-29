using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using CustomRenderer.Forms.Custom;
using CustomRenderer.Android.Custom;

[assembly: ExportRenderer (typeof (MyEntry), typeof (MyEntryRenderer))]

namespace CustomRenderer.Android.Custom
{
	class MyEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged (e);

			if (e.OldElement == null) {
				// perform initial setup
				// lets get a reference to the native control
				var nativeEditText = (global::Android.Widget.EditText)Control;
				// do whatever you want to the EditText here!

				nativeEditText.SetBackgroundColor (global::Android.Graphics.Color.DarkGray);
			}
		}
	}
}
