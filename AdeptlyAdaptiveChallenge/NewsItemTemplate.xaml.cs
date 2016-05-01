﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using AdeptlyAdaptiveChallenge.Models;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace AdeptlyAdaptiveChallenge
{
    public sealed partial class NewsItemTemplate : UserControl
    {
        public Models.NewsItems NewsItems { get { return this.DataContext as Models.NewsItems; } }

        public NewsItemTemplate()
        {
            this.InitializeComponent();
            this.DataContextChanged += (s, e) => Bindings.Update();
        }
    }
}