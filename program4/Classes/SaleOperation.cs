using program4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program4.Classes
{
    public  class SaleOperation
    {
        public void CustomerSaleOperationalis()
        {
            ConsoleProjectEntities1 db = new ConsoleProjectEntities1();
            var values = db.TblOperation.Where(x=>x.OperationType=="alış").ToList();
            foreach(var item in values)
            {
                Console.WriteLine("ID:" + item.id + " Name:" + item.CustomerName + " Surname:" + item.CustomerSurname + " CurrencyID:" + item.CurrencyID + " OperationType:" + item.OperationType + " CurrentValue:"+item.CurrentValue
                    +" Amount:"+item.Amount+" TotalPrice:"+item.TotalPrice);
               

            }

        }

        public void CustomerSaleOperationsatis()
        {
            ConsoleProjectEntities1 db = new ConsoleProjectEntities1();
            var values = db.TblOperation.Where(x => x.OperationType == "satis").ToList();
            foreach (var item in values)
            {
                Console.WriteLine("ID:" + item.id + " Name:" + item.CustomerName + " Surname:" + item.CustomerSurname + " CurrencyID:" + item.CurrencyID + " OperationType:" + item.OperationType + " CurrentValue:" + item.CurrentValue
                    + " Amount:" + item.Amount + " TotalPrice:" + item.TotalPrice);


            }
        }
}
