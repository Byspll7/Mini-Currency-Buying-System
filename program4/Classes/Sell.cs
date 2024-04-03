using program4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program4.Classes
{
  
    public class Sell
    {

        ConsoleProjectEntities1 db = new ConsoleProjectEntities1();

       public void MakeSale(string customerName ,string  customerSurname , int CurrencyCode,string operationType ,decimal currentValue ,decimal amount ,decimal totalAmount)
        {
            TblOperation t = new TblOperation();
            t.CustomerName = customerName;
            t.CustomerSurname = customerSurname;
            t.CurrencyID = CurrencyCode;
            t.OperationType = operationType;
            t.CurrentValue = currentValue;
            t.Amount = amount;
            t.TotalPrice = totalAmount;
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblOperation.Add(t);
            db.SaveChanges();
            Console.WriteLine("The sales transaction was completed successfully");

        }

        
    }
}
