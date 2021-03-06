using AppDB.ViewModels;
using System.Text.RegularExpressions;
using System.Windows;


namespace AppDB.Views
{
    /// <summary>
    /// Interaction logic for ViewLaptop.xaml
    /// </summary>
    public partial class ViewLaptop : Window
    {
        public ViewLaptop()
        {
            InitializeComponent();
            DataContext = new DataVM();
        }
        private void PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
