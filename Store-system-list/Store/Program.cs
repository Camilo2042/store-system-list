using System;
using System.Collections.Generic;
using System.Text;

namespace Store_system_list.Store
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Storelist storeList = new Storelist();

            Products headphones = new Products();
            headphones.name = "Headphones";
            headphones.price = 65;
            headphones.amount = 150;
            storeList.Addproduct(headphones);

            Products pendrive = new Products();
            pendrive.name = "Pen drive";
            pendrive.price = 150;
            pendrive.amount = 300;
            storeList.Addproduct(pendrive);

            Products usbcable = new Products();
            usbcable.name = "USB cable";
            usbcable.price = 100;
            usbcable.amount = 78;
            storeList.Addproduct(usbcable);

            Products externalharddrive = new Products();
            externalharddrive.name = "External hard drive";
            externalharddrive.price = 350;
            externalharddrive.amount = 100;
            storeList.Addproduct(externalharddrive);

            Products sdmemory = new Products();
            sdmemory.name = "SD memory";
            sdmemory.price = 145;
            sdmemory.amount = 350;
            storeList.Addproduct(sdmemory);

            Products laptop = new Products();
            laptop.name = "Laptop";
            laptop.price = 700;
            laptop.amount = 100;
            storeList.Addproduct(laptop);

            Products tablet = new Products();
            tablet.name = "Tablet";
            tablet.price = 550;
            tablet.amount = 150;
            storeList.Addproduct(tablet);

            Products tvbox = new Products();
            tvbox.name = "Tv box insert";
            tvbox.price = 230;


            Clients c1 = new Clients();
            c1.name = "Alice";
            storeList.Addclient(c1);

            Clients c2 = new Clients();
            c2.name = "Bruno";
            storeList.Addclient(c2);

            Clients c3 = new Clients();
            c3.name = "Daniel";
            storeList.Addclient(c3);

            Clients c4 = new Clients();
            c4.name = "Pedro insert";

            Sales s1 = new Sales();
            Sales s1a = new Sales();
            s1.Clients = c1;
            s1.Products = laptop;
            s1.Amount = 2;
            storeList.AddSale(s1);
            storeList.Addsl(s1);

            Sales s2 = new Sales();
            s2.Clients = c2;
            s2.Products = tablet;
            s2.Amount = 3;
            storeList.AddSale(s2);
            storeList.Addsl(s2);

            Sales s3 = new Sales();
            s3.Clients = c3;
            s3.Products = pendrive;
            s3.Amount = 5;
            storeList.AddSale(s3);
            storeList.Addsl(s3);

            Sales s4 = new Sales();
            s4.Clients = c4;
            s4.Products = tvbox;
            s4.Amount = 3;

            Console.WriteLine("      ---------- Products ----------\n");
            storeList.Print2();

            Console.WriteLine("\n      ---------- Clients ----------\n");
            storeList.Print();

            Console.WriteLine("\n      ---------- Sales ----------\n");
            storeList.Print3();

            Console.WriteLine("\n      ---------- Total sales ----------\n");

            float totalSales = storeList.getTotalSales();
            Console.WriteLine("Total sales amount: " + totalSales);

            Console.WriteLine("\n      ---------- Highest purchase ----------\n");

            Sales hpurch = storeList.Hightpurch();
            Console.WriteLine("Name of client with the highest purchase: " + hpurch.Clients.name);

            Console.WriteLine("\n      ---------- Top selling product ----------\n");

            Sales topp = storeList.topProduct();
            Console.WriteLine($"Top sold product: { topp.Products.name} - Amount:{ topp.Amount}");

            Console.WriteLine("\n      ---------- Avarage ----------\n");

            float avarage = storeList.Avarage();
            Console.WriteLine("Total sales amount: " + avarage);

            Console.WriteLine("\n      ---------- Sotck products ----------\n");
            storeList.Print4();

            Console.WriteLine("\n      ---------- Insert client c4 after c1----------\n");
            storeList.insertClient(c4, c1);
            storeList.Print();

            Console.WriteLine("\n      ---------- Delete client ----------\n");
            storeList.deleteClient();
            storeList.Print();

            Console.WriteLine("\n      ---------- Insert tv box after pendrive----------\n");
            storeList.insertProduct(tvbox, pendrive);
            storeList.Print2();

            Console.WriteLine("\n      ---------- Delete product ----------\n");
            storeList.deleteClient();
            storeList.Print2();

            Console.WriteLine("\n      ---------- Insert sale s4 after s1----------\n");
            storeList.insertSale(s4, s1);
            storeList.Print3();
        }
    }
}
