using AppDB.Models;
using AppDB.ViewModels;
using System.Windows;

namespace AppDB.Views
{
    /// <summary>
    /// Interaction logic for EditViewPC.xaml
    /// </summary>
    public partial class EditViewPC : Window
    {
        public EditViewPC(Pc pcToEdit)
        {
            InitializeComponent();
            DataContext = new DataVM();
            DataVM.SelectedPc = pcToEdit;
            DataVM.PcModel = pcToEdit.Model;            
            DataVM.PcSpeed = pcToEdit.Speed;
            DataVM.PcRam = pcToEdit.Ram;
            DataVM.PcHd = pcToEdit.Hd;
            DataVM.PcCd = pcToEdit.Cd;
            DataVM.PcPrice = pcToEdit.Price;
        }
    }
}
