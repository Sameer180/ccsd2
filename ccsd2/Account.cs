using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccsd2
{
    class Account
    {
        private string accountHolder, vehicleReg;
        List<string> currentVehicleDetails;
        List<List<string>> currentVehicleBills;
        Vehicle v;
        Billing b;

        public Account(string aH)
        {
            this.accountHolder = aH;
            v = new Vehicle(accountHolder);
        }

        public List<string> vehicleList()
        {
            List<string> ret = v.getRegDetails();
            return ret;
        }
        public List<string> getVehicleDetails(string reg)
        {
            this.vehicleReg = reg;
            this.currentVehicleDetails = v.getSpecificVehicleDetails(vehicleReg);
            getAllBills();
            return currentVehicleDetails;
        }

        public void getAllBills()
        {
            b = new Billing(vehicleReg);
            this.currentVehicleBills = b.getAllBills();
        }

        public List<List<string>> paidBillsToUi()
        {            
            List<List<string>> ret = new List<List<string>>();
            for (int i = 0; i < currentVehicleBills.Count; i++)
            {
                if (currentVehicleBills.ElementAt(i).ElementAt(5).Equals("True"))
                    ret.Add(currentVehicleBills.ElementAt(i));
            }
            return ret;
        }

        public List<List<string>> unpaidBillsToUi()
        {
            List<List<string>> ret = new List<List<string>>();
            for (int i = 0; i < currentVehicleBills.Count; i++)
            {
                if (currentVehicleBills.ElementAt(i).ElementAt(5).Equals("False"))
                    ret.Add(currentVehicleBills.ElementAt(i));
            }
            return ret;
        }

    }
}
