﻿// Copyright (c) The Perspex Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using Perspex.Controls;
using Perspex.Diagnostics;
using Perspex.Markup.Xaml;
using BehaviorsTestApplication.ViewModels;

namespace BehaviorsTestApplication.Views
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
            DevTools.Attach(this);
        }

        private void InitializeComponent()
        {
            PerspexXamlLoader.Load(this);
        }
    }
}
