using program4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace program4.Classes
{
    public class GetCurrency
    {
        ConsoleProjectEntities1 db = new ConsoleProjectEntities1();

        public void savecurrencydollar()
        {
           
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";

            var docXml = new XmlDocument();
            docXml.Load(today);

            string dollaybuying = docXml.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            Console.WriteLine("Buying Amount{USD}>>" + dollaybuying);
            dollaybuying = dollaybuying.Replace(".", ",");
            Console.WriteLine();
            string dollarselling = docXml.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            Console.WriteLine("Selling Amount{USD}>>" + dollarselling);
            dollarselling = dollarselling.Replace(".", ",");

           

            TblCurrencyValue t = new TblCurrencyValue();
            t.CurrencyID = 1;
            t.CurrencyBuying = decimal.Parse(dollaybuying);
            t.CurrencySelling = decimal.Parse(dollarselling);
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblCurrencyValue.Add(t);
            db.SaveChanges();


        }

        public void savecurrencyeuro()
        {
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var docXml = new XmlDocument();
            docXml.Load(today);

            string eurobuying = docXml.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            Console.WriteLine("Buying Amount{EUR}>>" + eurobuying);
            eurobuying = eurobuying.Replace(".", ",");
            Console.WriteLine();
            string euroselling = docXml.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            Console.WriteLine("Selling Amount{USD}>>" + euroselling);
            euroselling = euroselling.Replace(".", ",");



            TblCurrencyValue t = new TblCurrencyValue();
            t.CurrencyID = 2;
            t.CurrencyBuying = decimal.Parse(eurobuying);
            t.CurrencySelling = decimal.Parse(euroselling);
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblCurrencyValue.Add(t);
            db.SaveChanges();

        }

        public void savecurrencypound()
        {
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var docXml = new XmlDocument();
            docXml.Load(today);

            string poundbuying = docXml.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteBuying").InnerXml;
            Console.WriteLine("Buying Amount{GBP}>>" + poundbuying);
            poundbuying = poundbuying.Replace(".", ",");
            Console.WriteLine();
            string poundselling = docXml.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
            Console.WriteLine("Selling Amount{GBP}>>" + poundselling);
            poundselling = poundselling.Replace(".", ",");



            TblCurrencyValue t = new TblCurrencyValue();
            t.CurrencyID = 4;
            t.CurrencyBuying = decimal.Parse(poundbuying);
            t.CurrencySelling = decimal.Parse(poundselling);
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblCurrencyValue.Add(t);
            db.SaveChanges();
        }
        
        
           
    }
}
