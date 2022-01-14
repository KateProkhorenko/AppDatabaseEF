using AppDB.Models;
using AppDB.ViewModels;
using System.Windows;


namespace AppDB.Views
{
    /// <summary>
    /// Interaction logic for EditViewPrinter.xaml
    /// </summary>
    public partial class EditViewPrinter : Window
    {
        public EditViewPrinter(Printer printerToEdit)
        {
            InitializeComponent();
            DataContext = new DataVM();
            DataVM.SelectedPrinter = printerToEdit;
            DataVM.PrinterModel = printerToEdit.Model;
            DataVM.PrinterColor = printerToEdit.Color;
            DataVM.PrinterType = printerToEdit.Type;
            DataVM.PrinterPrice = printerToEdit.Price;
            
        }
    }
}
