using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using program4.Classes;
using program4.Model;

namespace program4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ConsoleProjectEntities1 db = new ConsoleProjectEntities1();
            GetCurrency getCurrency = new GetCurrency();
            Sell sale = new Sell();

            void list()
            {
                Console.WriteLine("");
                Console.WriteLine("Currency List");
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                var values = db.TblCurrency.ToList();
                foreach (var item in values)
                {
                    Console.WriteLine(item.id + "." + item.CurrencyName + ">>" + item.CurrencySymbol);
                }

            }

            void activecurrency()
            {
                Console.WriteLine();
                Console.WriteLine("Active Currency");
                Console.WriteLine();
                var values2 = db.TblCurrencyValue.ToList();
                foreach(var item in values2 )
                {
                    Console.WriteLine("Currency:" + item.TblCurrency.CurrencyName+" "+"Buy:"+item.CurrencyBuying+" "+"Sell:"+item.CurrencySelling);
                }
            }
                
        

            void GetCurrencyClass()
            {
                
                getCurrency.savecurrencydollar();
                getCurrency.savecurrencyeuro();
                getCurrency.savecurrencypound();
            }


            void ara()
            {
                Console.WriteLine("***********************************");
            }


            //Operations
            Console.WriteLine("Welcome to currency operation!");
            ara();
            Console.WriteLine("Admin: " + " DateTime: "+DateTime.Now.ToShortDateString());
            ara();
            Console.WriteLine("Select Operation: ");
            ara();
            Console.WriteLine("1)Currency List");
            Console.WriteLine("2)Current Rates");
            Console.WriteLine("3)Sell");
            Console.WriteLine("4)Sales to customers");
            Console.WriteLine("5)Sales received from customers");
            Console.WriteLine("6)Save rates to database");
            Console.WriteLine("7)Help");
            Console.WriteLine("8)Log out");
            ara();
            Console.Write("Transaction Number: ");

            string choose;
            choose = Console.ReadLine();
            
            if(choose=="1"|| choose=="01")
            {
                list();
            }
            if(choose=="2" || choose=="01")
            {
                activecurrency();
            }
            if(choose=="3" || choose=="03")
            {
                Console.WriteLine();
                Console.Write("Customer Name: ");
                string customerName = Console.ReadLine();
                Console.Write("Customer Surname:");
                string customerSurname = Console.ReadLine();
                Console.Write("CurrencyID:");
                int currencyCode = int.Parse(Console.ReadLine());
                Console.Write("Operation Type: ");
                string operationType = Console.ReadLine();
                Console.Write("Currency Value:");
                decimal currentValue = decimal.Parse(Console.ReadLine());
                Console.Write("Received Amount: ");
                decimal amount = decimal.Parse(Console.ReadLine());
                Console.Write("Total Amount: ");
                decimal totalamount = decimal.Parse(Console.ReadLine());


                sale.MakeSale(customerName,customerSurname,currencyCode,operationType,currentValue,amount,totalamount);
            }
            if(choose=="4"|| choose=="04")
            {
                SaleOperation saleOperation = new SaleOperation();
                saleOperation.CustomerSaleOperationalis();
            }
            if(choose=="5"||choose=="05")
            {
                SaleOperation saleOperation = new SaleOperation();
                saleOperation.CustomerSaleOperationsatis();
            }
            if(choose=="6"|| choose=="06")
            {
                GetCurrencyClass();
                Console.WriteLine("Currency added successfully");
            }
            if (choose == "7" || choose == "07")
            {
                Console.WriteLine("If you encounter a possible error, contact us");
            }
            if (choose == "8" || choose == "08")
            {
                Environment.Exit(1);
            }








            Console.ReadLine();
        }
    }
}
