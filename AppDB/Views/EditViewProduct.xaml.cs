using AppDB.Models;
using AppDB.ViewModels;
using System.Windows;

namespace AppDB.Views
{
    /// <summary>
    /// Interaction logic for EditViewProduct.xaml
    /// </summary>
    public partial class EditViewProduct : Window
    {
        public EditViewProduct(Product productToEdit)
        {
            InitializeComponent();
            DataContext = new DataVM();
            DataVM.SelectedProduct = productToEdit;
            DataVM.ProductMaker = productToEdit.Maker;
            DataVM.ProductModel = productToEdit.Model;
            DataVM.ProductType = productToEdit.Type;
        }
    }
}
