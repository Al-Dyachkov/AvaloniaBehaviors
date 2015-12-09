﻿// Copyright (c) The Perspex Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System.Windows.Threading;
using Perspex;
using XamlTestApplication.Views;

namespace XamlTestApplication
{
    internal class Program
    {
        private static void Main()
        {
            var foo = Dispatcher.CurrentDispatcher;

            App application = new App
            {

            };

            var window = new MainWindow();
            window.Show();
            Application.Current.Run(window);
        }
    }
}