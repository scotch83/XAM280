﻿using System;
using System.Collections.Generic;
using FlagData;
using Xamarin.Forms;

namespace FunFlacts
{
    public partial class AllFlags : ContentPage
    {
        public AllFlags()
        {
            InitializeComponent();
            BindingContext = DependencyService.Get<FunFlactsViewModel>();
        }
    }
}
