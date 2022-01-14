using AppDB.Models;
using AppDB.ViewModels;
using System.Windows;


namespace AppDB.Views
{
    /// <summary>
    /// Interaction logic for EditViewLaptop.xaml
    /// </summary>
    public partial class EditViewLaptop : Window
    {
        public EditViewLaptop(Laptop laptopToEdit)
        {
            InitializeComponent();
            DataContext = new DataVM();
            DataVM.SelectedLaptop = laptopToEdit;
            DataVM.LaptopModel = laptopToEdit.Model;
            DataVM.LaptopSpeed = laptopToEdit.Speed;
            DataVM.LaptopRam = laptopToEdit.Ram;
            DataVM.LaptopHd = laptopToEdit.Hd;
            DataVM.LaptopPrice = laptopToEdit.Price;
            DataVM.LaptopScreen = laptopToEdit.Screen;
        }
    }
}
