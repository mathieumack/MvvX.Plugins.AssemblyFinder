﻿using Client.SampleClasses;
using MvvX.Plugins.AssemblyFinder.WindowsUWP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Client.UWP
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnFindClasses_Click(object sender, RoutedEventArgs e)
        {
            Assembly.Load(new AssemblyName("Client.SampleClasses"));

            var typeFinder = new AssemblyFinder();
            var myListOfClassesOrInterfaces = typeFinder.FindClassesOfType(typeof(IService)).ToList();
            btnFindClasses.Content = myListOfClassesOrInterfaces.Count() + " classes finded." + string.Join("/", myListOfClassesOrInterfaces.Select(f => f.Name));
        }
    }
}