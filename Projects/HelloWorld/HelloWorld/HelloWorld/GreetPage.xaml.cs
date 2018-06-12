﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetPage : ContentPage
	{
		public GreetPage ()
		{
			InitializeComponent ();

            slider.Value = 0.5;

            // new way of writing Device.OnPlatform
            //switch (Device.RuntimePlatform)
            //{
            //    case Device.iOS:
            //        Padding = new Thickness(0, 20, 0, 0);
            //        break;
            //    case Device.Android:
            //        Padding = new Thickness(10, 20, 0, 0);
            //        break;
            //    case Device.WPF:
            //        Padding = new Thickness(30, 20, 0, 0);
            //        break;
            //}

            //var x = new OnPlatform<Thickness>
            //{
            //    Android = new Thickness(0),
            //    iOS = new Thickness(0, 20, 0, 0)
            //};

            //Padding = x;
		}
    }
}