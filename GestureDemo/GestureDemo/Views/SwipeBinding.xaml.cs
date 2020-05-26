﻿using GestureDemo.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GestureDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwipeBinding : ContentPage
    {
        public SwipeBinding()
        {
            InitializeComponent();
            BindingContext = new SwipeCommandPageViewModel();
        }
    }
}