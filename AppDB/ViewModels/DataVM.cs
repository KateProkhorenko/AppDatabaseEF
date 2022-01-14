using AppDB.Data;
using AppDB.Models;
using AppDB.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace AppDB.ViewModels
{
    public class DataVM : INotifyPropertyChanged
    {
        //все PC
        private List<Pc> allPcs = DataModel.GetAllPcs();
        public List<Pc> AllPcs
        {
            get { return allPcs; }
            set
            {
                allPcs = value;
                NotifyPropertyChanged("AllPcs");
            }
        }

        //все Laptop
        private List<Laptop> allLaptops = DataModel.GetAllLaptops();
        public List<Laptop> AllLaptops
        {
            get { return allLaptops; }
            set
            {
                allLaptops = value;
                NotifyPropertyChanged("AllLaptops");
            }
        }

        //все Printer
        private List<Printer> allPrinters = DataModel.GetAllPrinters();
        public List<Printer> AllPrinters
        {
            get { return allPrinters; }
            set
            {
                allPrinters = value;
                NotifyPropertyChanged("AllPrinters");
            }
        }

        //все Product
        private List<Product> allProducts = DataModel.GetAllProducts();
        public List<Product> AllProducts
        {
            get { return allProducts; }
            set
            {
                allProducts = value;
                NotifyPropertyChanged("AllProducts");
            }
        }
        // Свойства для PC
        public static int PcCode { get; set; }
        public static string PcModel { get; set; }
        public static short PcSpeed { get; set; }
        public static short PcRam { get; set; }
        public static float PcHd { get; set; }
        public static string PcCd { get; set; }
        public static decimal? PcPrice { get; set; }

        // Свойства для Laptop
        public static int LaptopCode { get; set; }
        public static string LaptopModel { get; set; }
        public static short LaptopSpeed { get; set; }
        public static short LaptopRam { get; set; }
        public static float LaptopHd { get; set; }
        public static decimal? LaptopPrice { get; set; }
        public static byte LaptopScreen { get; set; }

        // Свойства для Printer
        public static int PrinterCode { get; set; }
        public static string PrinterModel { get; set; }
        public static string PrinterColor { get; set; }
        public static string PrinterType { get; set; }
        public static decimal? PrinterPrice { get; set; }

        // Свойства для Product
        public static string ProductMaker { get; set; }
        public static string ProductModel { get; set; }
        public static string ProductType { get; set; }

        // Свойства для выделения элементов
        public TabItem SelectedTabItem { get; set; }
        public static Pc SelectedPc { get; set; }
        public static Laptop SelectedLaptop { get; set; }
        public static Printer SelectedPrinter { get; set; }
        public static Product SelectedProduct { get; set; }



        #region Commands to add
        private RelayCommand addNewPc;
        public RelayCommand AddNewPc
        {
            get {
                return addNewPc ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "";
                    if (PcCode == 0)
                    {
                        SetRedBlockControll(wnd, "codeBlock");
                    }
                    if (PcModel == null || PcModel.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "modelBlock");
                    }
                    if (PcSpeed == 0)
                    {
                        SetRedBlockControll(wnd, "speedBlock");
                    }
                    if (PcRam == 0)
                    {
                        SetRedBlockControll(wnd, "ramBlock");
                    }
                    if (PcHd == 0)
                    {
                        SetRedBlockControll(wnd, "hdBlock");
                    }
                    if (PcCd == null || PcCd.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "cdBlock");
                    }
                    if (PcPrice == 0)
                    {
                        SetRedBlockControll(wnd, "priceBlock");
                    }

                    else
                    {
                        resultStr = DataModel.CreateNewPC(PcCode, PcModel, PcSpeed, PcRam, PcHd, PcCd, PcPrice);
                        UpdateAllDataView();
                        ShowMessage(resultStr);
                        SetNullValuesToProperties();
                        wnd.Close();
                    }
                    
                }
                  );
            }
        
        }

        private RelayCommand addNewLaptop;
        public RelayCommand AddNewLaptop
        {
            get
            {
                return addNewLaptop ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "";
                    if (LaptopCode == 0)
                    {
                        SetRedBlockControll(wnd, "codeBlock");
                    }
                    if (LaptopModel == null || LaptopModel.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "modelBlock");
                    }
                    if (LaptopSpeed == 0)
                    {
                        SetRedBlockControll(wnd, "speedBlock");
                    }
                    if (LaptopRam == 0)
                    {
                        SetRedBlockControll(wnd, "ramBlock");
                    }
                    if (LaptopHd == 0)
                    {
                        SetRedBlockControll(wnd, "hdBlock");
                    }
                    if (LaptopPrice == 0)
                    {
                        SetRedBlockControll(wnd, "priceBlock");
                    }
                    if (LaptopScreen == 0)
                    {
                        SetRedBlockControll(wnd, "screenBlock");
                    }

                    else
                    {
                        resultStr = DataModel.CreateNewLaptop(LaptopCode, LaptopModel, LaptopSpeed, LaptopRam, LaptopHd, LaptopPrice, LaptopScreen);
                        UpdateAllDataView();
                        ShowMessage(resultStr);
                        SetNullValuesToProperties();
                        wnd.Close();
                    }

                }
                  );
            }

        }

        private RelayCommand addNewPrinter;
        public RelayCommand AddNewPrinter
        {
            get
            {
                return addNewPrinter ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "";
                    if (PrinterCode == 0)
                    {
                        SetRedBlockControll(wnd, "codeBlock");
                    }
                    if (PrinterModel == null || PrinterModel.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "modelBlock");
                    }
                    if (PrinterColor == null || PrinterColor.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "colorBlock");
                    }
                    if (PrinterType == null || PrinterType.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "typeBlock");
                    }
                    if (PrinterPrice == 0)
                    {
                        SetRedBlockControll(wnd, "priceBlock");
                    }
                    else
                    {
                        resultStr = DataModel.CreateNewPrinter(PrinterCode, PrinterModel, PrinterColor, PrinterType, PrinterPrice);
                        UpdateAllDataView();
                        ShowMessage(resultStr);
                        SetNullValuesToProperties();
                        wnd.Close();
                    }

                }
                  );
            }

        }

        private RelayCommand addNewProduct;
        public RelayCommand AddNewProduct
        {
            get
            {
                return addNewProduct ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "";
                    if (ProductMaker == null || ProductMaker.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "makerBlock");
                    }
                    if (ProductModel == null || ProductModel.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "modelBlock");
                    }
                    if (ProductType == null || ProductType.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "typeBlock");
                    }
                    else
                    {
                        resultStr = DataModel.CreateNewProduct(ProductMaker, ProductModel, ProductType);
                        UpdateAllDataView();
                        ShowMessage(resultStr);
                        SetNullValuesToProperties();
                        wnd.Close();
                    }

                }
                  );
            }

        }

        #endregion

        private RelayCommand deleteItem;
        public RelayCommand DeleteItem
        {
            get
            {
                return deleteItem ?? new RelayCommand(obj =>
                {
                    string resultStr = "Нет выбранных элементов";
                    //если PC
                    if (SelectedTabItem.Name == "PcTab" && SelectedPc != null)
                    {
                        resultStr = DataModel.DeletePC(SelectedPc);
                        UpdateAllDataView();
                    }
                    //если Laptop
                    if (SelectedTabItem.Name == "LaptopsTab" && SelectedLaptop != null)
                    {
                        resultStr = DataModel.DeleteLaptop(SelectedLaptop);
                        UpdateAllDataView();
                    }
                    //если Printer
                    if (SelectedTabItem.Name == "PrintersTab" && SelectedPrinter != null)
                    {
                        resultStr = DataModel.DeletePrinter(SelectedPrinter);
                        UpdateAllDataView();
                    }
                    //если Product
                    if (SelectedTabItem.Name == "ProductsTab" && SelectedProduct != null)
                    {
                        resultStr = DataModel.DeleteProduct(SelectedProduct);
                        UpdateAllDataView();
                    }
                    //обновление
                    SetNullValuesToProperties();
                    ShowMessage(resultStr);
                }
                    );
            }
        }
        #region Commands to edit
        private RelayCommand editPc;
        public RelayCommand EditPc
        {
            get
            {
                return editPc ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string resultStr = "Не выбран элемент";
                   
                    if (SelectedPc != null)
                    {
                          resultStr = DataModel.EditPC(SelectedPc, PcModel, PcSpeed, PcRam, PcHd, PcCd, PcPrice);
                          UpdateAllDataView();
                          SetNullValuesToProperties();
                          ShowMessage(resultStr);
                          window.Close();                        
                    }
                    else ShowMessage(resultStr);

                }
                );
            }
        }
        private RelayCommand editLaptop;
        public RelayCommand EditLaptop
        {
            get
            {
                return editLaptop ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string resultStr = "Не выбран элемент";

                    if (SelectedLaptop != null)
                    {
                        resultStr = DataModel.EditLaptop(SelectedLaptop, LaptopModel, LaptopSpeed, LaptopRam, LaptopHd, LaptopPrice, LaptopScreen);
                        UpdateAllDataView();
                        SetNullValuesToProperties();
                        ShowMessage(resultStr);
                        window.Close();
                    }
                    else ShowMessage(resultStr);

                }
                );
            }
        }
        private RelayCommand editPrinter;
        public RelayCommand EditPrinter
        {
            get
            {
                return editPrinter ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string resultStr = "Не выбран элемент";

                    if (SelectedPrinter!= null)
                    {
                        resultStr = DataModel.EditPrinter(SelectedPrinter, PrinterModel, PrinterColor, PrinterType, PrinterPrice);
                        UpdateAllDataView();
                        SetNullValuesToProperties();
                        ShowMessage(resultStr);
                        window.Close();
                    }
                    else ShowMessage(resultStr);

                }
                );
            }
        }
        private RelayCommand editProduct;
        public RelayCommand EditProduct
        {
            get
            {
                return editProduct ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string resultStr = "Не выбран элемент";

                    if (SelectedProduct != null)
                    {
                        resultStr = DataModel.EditProduct(SelectedProduct, ProductMaker, ProductModel, ProductType);
                        UpdateAllDataView();
                        SetNullValuesToProperties();
                        ShowMessage(resultStr);
                        window.Close();
                    }
                    else ShowMessage(resultStr);

                }
                );
            }
        }

        #endregion

        #region Commands to open windows
        private RelayCommand openViewLaptopWnd;
        public RelayCommand OpenViewLaptopWnd
        {
            get
            {
                return openViewLaptopWnd ?? new RelayCommand(obj =>
                {
                    OpenViewLaptopMethod();
                }
                    );
            }
        }
        private RelayCommand openViewPCWnd;
        public RelayCommand OpenViewPCWnd
        {
            get
            {
                return openViewPCWnd ?? new RelayCommand(obj =>
                {
                    OpenViewPCMethod();
                }
                    );
            }
        }

        private RelayCommand openViewPrinterWnd;
        public RelayCommand OpenViewPrinterWnd
        {
            get
            {
                return openViewPrinterWnd ?? new RelayCommand(obj =>
                {
                    OpenViewPrinterMethod();
                }
                    );
            }
        }

        private RelayCommand openViewProductWnd;
        public RelayCommand OpenViewProductWnd
        {
            get
            {
                return openViewProductWnd ?? new RelayCommand(obj =>
                {
                    OpenViewProductMethod();
                }
                    );
            }
        }

        private RelayCommand openEditItemWnd;
        public RelayCommand OpenEditItemWnd
        {
            get
            {
                return openEditItemWnd ?? new RelayCommand(obj =>
                {
                    string resultStr = "Не выбран элемент";
                    //если PC
                    if (SelectedTabItem.Name == "PcTab" && SelectedPc != null)
                    {
                        EditViewPCMethod(SelectedPc);
                    }
                    //если Laptop
                    if (SelectedTabItem.Name == "LaptopsTab" && SelectedLaptop != null)
                    {
                        EditViewLaptopMethod(SelectedLaptop);
                    }
                    //если Printer
                    if (SelectedTabItem.Name == "PrintersTab" && SelectedPrinter != null)
                    {
                        EditViewPrinterMethod(SelectedPrinter);
                    }
                    //если Product
                    if (SelectedTabItem.Name == "ProductsTab" && SelectedProduct != null)
                    {
                        EditViewProductMethod(SelectedProduct);
                    }
                }
                    );
            }
        }
        #endregion


        #region Methods to open window
        //Методы открытия окон
        private void OpenViewPCMethod()
        {
            ViewPC newPC = new ViewPC();
            SetCenterPositionAndOpen(newPC);
        }

        private void OpenViewLaptopMethod()
        {
            ViewLaptop newLaptop = new ViewLaptop();
            SetCenterPositionAndOpen(newLaptop);
        }

        private void OpenViewPrinterMethod()
        {
            ViewPrinter newPrinter = new ViewPrinter();
            SetCenterPositionAndOpen(newPrinter);
        }

        private void OpenViewProductMethod()
        {
            ViewProduct newProduct = new ViewProduct();
            SetCenterPositionAndOpen(newProduct);
        }
        //Методы редактирования
        private void EditViewPCMethod(Pc pc)
        {
            EditViewPC editPC = new EditViewPC(pc);
            SetCenterPositionAndOpen(editPC);
        }

        private void EditViewLaptopMethod(Laptop laptop)
        {
            EditViewLaptop editLaptop = new EditViewLaptop(laptop);
            SetCenterPositionAndOpen(editLaptop);
        }

        private void EditViewPrinterMethod(Printer printer)
        {
            EditViewPrinter editPrinter = new EditViewPrinter(printer);
            SetCenterPositionAndOpen(editPrinter);
        }

        private void EditViewProductMethod(Product product)
        {
            EditViewProduct editProduct = new EditViewProduct(product);
            SetCenterPositionAndOpen(editProduct);
        }


        private void SetCenterPositionAndOpen(Window window)
        {
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }
        #endregion

        #region Update Views
        private void SetNullValuesToProperties()
        {
            //для PC
            PcCode = 0;
            PcModel = null;
            PcSpeed = 0;
            PcRam = 0;
            PcHd = 0;
            PcCd = null;
            PcPrice = 0;

            //для Laptop
            LaptopCode = 0; 
            LaptopModel = null;
            LaptopSpeed = 0;
            LaptopRam = 0;
            LaptopHd = 0;
            LaptopPrice = 0;
            LaptopScreen = 0;

            //для Printer
            PrinterCode = 0;
            PrinterModel = null;
            PrinterColor = null;
            PrinterType = null;
            PrinterPrice = 0;

            //для Product
            ProductMaker = null;
            ProductModel = null;
            ProductType = null;
        }
        private void UpdateAllDataView()
        {
            UpdateAllPcsView();
            UpdateAllLaptopsView();
            UpdateAllPrintersView();
            UpdateAllProductsView();
        }
        private void UpdateAllPcsView()
        {
            AllPcs = DataModel.GetAllPcs();
            MainWindow.AllPcsView.ItemsSource = null;
            MainWindow.AllPcsView.Items.Clear();
            MainWindow.AllPcsView.ItemsSource = AllPcs;
            MainWindow.AllPcsView.Items.Refresh();
        }
        private void UpdateAllLaptopsView()
        {
            AllLaptops = DataModel.GetAllLaptops();
            MainWindow.AllLaptopsView.ItemsSource = null;
            MainWindow.AllLaptopsView.Items.Clear();
            MainWindow.AllLaptopsView.ItemsSource = AllLaptops;
            MainWindow.AllLaptopsView.Items.Refresh();
        }
        private void UpdateAllPrintersView()
        {
            AllPrinters = DataModel.GetAllPrinters();
            MainWindow.AllPrintersView.ItemsSource = null;
            MainWindow.AllPrintersView.Items.Clear();
            MainWindow.AllPrintersView.ItemsSource = AllPrinters;
            MainWindow.AllPrintersView.Items.Refresh();
        }
        private void UpdateAllProductsView()
        {
            AllProducts = DataModel.GetAllProducts();
            MainWindow.AllProductsView.ItemsSource = null;
            MainWindow.AllProductsView.Items.Clear();
            MainWindow.AllProductsView.ItemsSource = AllProducts;
            MainWindow.AllProductsView.Items.Refresh();
        }

        #endregion

        private void ShowMessage(string message)
        {
            ViewMessage viewMessage = new ViewMessage(message);
            SetCenterPositionAndOpen(viewMessage);
        }
        private void SetRedBlockControll(Window wnd, string blockName)
        {
            Control block = wnd.FindName(blockName) as Control;
            block.BorderBrush = Brushes.Red;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
