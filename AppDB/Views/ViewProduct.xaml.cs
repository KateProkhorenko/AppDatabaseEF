using AppDB.ViewModels;
using System.Text.RegularExpressions;
using System.Windows;



namespace AppDB.Views
{
    /// <summary>
    /// Interaction logic for ViewProduct.xaml
    /// </summary>
    public partial class ViewProduct : Window
    {
        public ViewProduct()
        {
            InitializeComponent();
            DataContext = new DataVM();

        }
       
    }
}
