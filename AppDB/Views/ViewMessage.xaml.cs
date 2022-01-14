using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace AppDB.Views
{
    /// <summary>
    /// Interaction logic for ViewMessage.xaml
    /// </summary>
    public partial class ViewMessage : Window
    {
        public ViewMessage(string text)
        {
            InitializeComponent();
            MessageText.Text = text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
