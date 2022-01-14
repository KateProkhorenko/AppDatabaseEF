using AppDB.Data;
using System.Linq;
using System.Collections.Generic;

namespace AppDB.Models
{
    public static class DataModel
    {
        //Получить все PC

        public static List<Pc> GetAllPcs()
        {
            using (computerContext db = new computerContext())
            {
                var result = db.Pcs.ToList();
                return result;
            }
        }
        //Получить все Laptop
        public static List<Laptop> GetAllLaptops()
        {
            using (computerContext db = new computerContext())
            {
                var result = db.Laptops.ToList();
                return result;
            }
        }
        //Получить все Printer
        public static List<Printer> GetAllPrinters()
        {
            using (computerContext db = new computerContext())
            {
                var result = db.Printers.ToList();
                return result;
            }
        }
        //Получить все Product
        public static List<Product> GetAllProducts()
        {
            using (computerContext db = new computerContext())
            {
                var result = db.Products.ToList();
                return result;
            }
        }

        // Создать PC
        public static string CreateNewPC(int code,string model, short speed, short ram, float hd, string cd, decimal? price)
        {
            string result = "Уже сущесвует";
            using (computerContext db = new computerContext())
            {
                //проверяем сущесвует ли PC
                bool checkIsExist = db.Pcs.Any(el => el.Code == code && el.Model == model && el.Speed == speed && el.Ram == ram &&
                el.Hd == hd && el.Cd == cd && el.Price == price);

                if (!checkIsExist)
                {
                    Pc newPC = new Pc
                    {
                        Code = code,
                        Model = model,
                        Speed = speed,
                        Ram = ram,
                        Hd = hd,
                        Cd = cd,
                        Price = price
                    };
                    db.Pcs.Add(newPC);
                    db.SaveChanges();
                    result = "Выполнено";
                }

                return result;
            }

        }

        // Создать Laptop
        public static string CreateNewLaptop(int code, string model, short speed, short ram, float hd, decimal? price, byte screen)
        {
            string result = "Уже сущесвует";
            using (computerContext db = new computerContext())
            {
                //проверяем сущесвует ли Laptop
                bool checkIsExist = db.Laptops.Any(el => el.Code == code && el.Model == model && el.Speed == speed && el.Ram == ram &&
                el.Hd == hd && el.Price == price && el.Screen == screen);

                if (!checkIsExist)
                {
                    Laptop newLaptop = new Laptop
                    {
                        Code = code,
                        Model = model,
                        Speed = speed,
                        Ram = ram,
                        Hd = hd,
                        Price = price,
                        Screen = screen
                    };
                    db.Laptops.Add(newLaptop);
                    db.SaveChanges();
                    result = "Выполнено";
                }

                return result;
            }

        }
        // Создать Printer
        public static string CreateNewPrinter(int code, string model, string color, string type, decimal? price)
        {
            string result = "Уже сущесвует";
            using (computerContext db = new computerContext())
            {
                //проверяем сущесвует ли Printer
                bool checkIsExist = db.Printers.Any(el => el.Code == code && el.Model == model && el.Color == color && el.Type == type && el.Price == price);

                if (!checkIsExist)
                {
                    Printer newPrinter = new Printer
                    {
                        Code = code,
                        Model = model,
                        Color = color,
                        Type = type,
                        Price = price
                    };
                    db.Printers.Add(newPrinter);
                    db.SaveChanges();
                    result = "Выполнено";
                }

                return result;
            }

        }
        // Создать Product
        public static string CreateNewProduct(string maker, string model, string type)
        {
            string result = "Уже сущесвует";
            using (computerContext db = new computerContext())
            {
                //проверяем сущесвует ли Product
                bool checkIsExist = db.Products.Any(el => el.Maker == maker && el.Model == model && el.Type == type);

                if (!checkIsExist)
                {
                    Product newProduct = new Product
                    {
                        Maker = maker,
                        Model = model,
                        Type = type
                    };
                    db.Products.Add(newProduct);
                    db.SaveChanges();
                    result = "Выполнено";
                }

                return result;
            }

        }

        //Удаление PC
        public static string DeletePC(Pc pc)
        {
            string result = "PC не существует";
            using (computerContext db = new computerContext())
            {
                db.Pcs.Remove(pc);
                db.SaveChanges();
                result = "Выполнено. PC " + pc.Model + " удален";
            }
            return result;
        }
        //Удаление Laptop
        public static string DeleteLaptop(Laptop laptop)
        {
            string result = "Laptop не существует";
            using (computerContext db = new computerContext())
            {
                db.Laptops.Remove(laptop);
                db.SaveChanges();
                result = "Выполнено. Laptop " + laptop.Model + " удален";
            }
            return result;
        }
        //Удаление Printer
        public static string DeletePrinter(Printer printer)
        {
            string result = "Printer не существует";
            using (computerContext db = new computerContext())
            {
                db.Printers.Remove(printer);
                db.SaveChanges();
                result = "Выполнено. Printer " + printer.Model + " удален";
            }
            return result;
        }
        //Удаление Product
        public static string DeleteProduct(Product product)
        {
            string result = "Product не существует";
            using (computerContext db = new computerContext())
            {
                db.Products.Remove(product);
                db.SaveChanges();
                result = "Выполнено. Product " + product.Model + " удален";
            }
            return result;
        }

        //Редактирование PC
        public static string EditPC(Pc oldPC, string newmodel, short newspeed, short newram, float newhd, string newcd, decimal? newprice)
        {
            string result = "PC не существует";
            using (computerContext db = new computerContext())
            {
                Pc pc = db.Pcs.FirstOrDefault(d => d.Code == oldPC.Code);
                pc.Model = newmodel;
                pc.Speed = newspeed;
                pc.Ram = newram;
                pc.Hd = newhd;
                pc.Cd = newcd;
                pc.Price = newprice;
                db.SaveChanges();
                result = "Выполнено. PC " + pc.Model + " изменен";
            }
            return result;
        }
        //Редактирование Laptop
        public static string EditLaptop(Laptop oldLaptop, string newmodel, short newspeed, short newram, float newhd, decimal? newprice, byte newscreen)
        {
            string result = "Laptop не существует";
            using (computerContext db = new computerContext())
            {
                Laptop laptop = db.Laptops.FirstOrDefault(d => d.Code == oldLaptop.Code);
                laptop.Model = newmodel;
                laptop.Speed = newspeed;
                laptop.Ram = newram;
                laptop.Hd = newhd;
                laptop.Price = newprice;
                laptop.Screen = newscreen;
                db.SaveChanges();
                result = "Выполнено. Laptop " + laptop.Model + " изменен";
            }
            return result;
        }
        //Редактирование Printer
        public static string EditPrinter(Printer oldPrinter, string newmodel, string newcolor, string newtype, decimal? newprice)
        {
            string result = "Printer не существует";
            using (computerContext db = new computerContext())
            {
                Printer printer = db.Printers.FirstOrDefault(d => d.Code == oldPrinter.Code);
                printer.Model = newmodel;
                printer.Color = newcolor;
                printer.Type = newtype;
                printer.Price = newprice;
                db.SaveChanges();
                result = "Выполнено. Laptop " + printer.Model + " изменен";
            }
            return result;
        }
        //Редактирование Product
        public static string EditProduct(Product oldProduct, string newmaker, string newmodel, string newtype)
        {
            string result = "Printer не существует";
            using (computerContext db = new computerContext())
            {
                Product product = db.Products.FirstOrDefault(d => d.Maker == newmaker);
                product.Model = newmodel;
                product.Type = newtype;
                db.SaveChanges();
                result = "Выполнено. Laptop " + product.Model + " изменен";
            }
            return result;
        }
    }
}
