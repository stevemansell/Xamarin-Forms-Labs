﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Xamarin.Forms.Labs.Sample.Pages.Controls
{    
    public partial class ImageGallery : ContentPage
    {    
        public ImageGallery ()
        {
            InitializeComponent ();
            this.BindingContext = new MainViewModel ();
        }

        protected override  void OnAppearing ()
        {
           (this.BindingContext as MainViewModel).AddImages ();
            base.OnAppearing ();
        }
    }
}

