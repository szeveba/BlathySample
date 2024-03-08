﻿using FrameSample.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FrameSample.View
{
    /// <summary>
    /// Interaction logic for BookEditorPage.xaml
    /// </summary>
    public partial class BookEditorPage : Page
    {
        public BookEditorPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CB_Genre.ItemsSource = Enum.GetValues(typeof(GenreType));
        }
    }
}
