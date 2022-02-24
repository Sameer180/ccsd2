using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccsd2
{ // aggregation not composition update er diagrams
    class Billing
    {
        //assigns year, month, day, hour, min, seconds
        //DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);
        public struct bill
        { 
            public int id;
            public DateTime dt;
            public string registration;
            public float distanceKM, price;
            public bool paid;
        }
        private List<bill> bills = new List<bill>();

        private string currentRegistration;
        public Billing(string cr)
        {
            this.currentRegistration = cr;
            initList();
            bills.Count();
        }

        private void initList()
        {
            string[] regNums = { "aa55 aaa", "bb55 bbb", "cc55 ccc", "dd55 ddd", "ee55 eee" };
            int r = 0;
            for (int i = 0; i < 10; i++)
            {
                var b = new bill();
                b.id = i;
                b.dt = new DateTime(2022, 02, 01, 10, 10, 10); // different days
                b.distanceKM = 5.5F;
                b.price = 3.12F;

                if (i % 2 == 1)
                {
                    b.registration = regNums[r++];        // 1 paid and 1 unpaid bill for each vehicle
                    b.paid = false;                      
                }
                else
                {
                    b.registration = regNums[r];          // 
                    b.paid = true;                      
                }
                this.bills.Add(b);
            }
        }

        public List<List<string>> getAllBills()
        {
            List<List<string>> ret = new List<List<string>>();
            List<string> temp;
            for (int i = 0; i < bills.Count; i++)
            {
                if (bills.ElementAt(i).registration == currentRegistration)
                {
                    temp = new List<string>();
                    temp.Add(bills.ElementAt(i).id.ToString());
                    temp.Add(bills.ElementAt(i).dt.ToString());
                    temp.Add(bills.ElementAt(i).registration);
                    temp.Add(bills.ElementAt(i).distanceKM.ToString());
                    temp.Add(bills.ElementAt(i).price.ToString());
                    temp.Add(bills.ElementAt(i).paid.ToString());
                    ret.Add(temp);
                }
            }
            return ret;
        }
    }// class
}
