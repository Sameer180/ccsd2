using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccsd2
{
    class Vehicle 
    {
        private struct vehicle
        {
            public string owner, registration, make, model, type;
        }
        private List<vehicle> vehicles = new List<vehicle>();

        private string currentOwner;
        public Vehicle(string co)
        {
            this.currentOwner = co;
            initList();
        }

        private void initList()
        {
            var v = new vehicle();
            v.owner = "Steven (Transport Dept)";
            v.registration = "aa55 aaa";
            v.make = "ADL";
            v.model = "Enviro400EV";
            v.type = "Bus";
            vehicles.Add(v);

            v = new vehicle();
            v.owner = "Steven (Transport Dept)";
            v.registration = "bb55 bbb";
            v.make = "DAF";
            v.model = "XF";
            v.type = "Lorry";
            vehicles.Add(v);

            v = new vehicle();
            v.owner = "Steven (Transport Dept)";
            v.registration = "cc55 ccc";
            v.make = "BMW";
            v.model = "308i";
            v.type = "Company Car";
            vehicles.Add(v);

            v = new vehicle();
            v.owner = "John (Regular User)";
            v.registration = "dd55 ddd";
            v.make = "Toyota";
            v.model = "Auris";
            v.type = "Car";
            vehicles.Add(v);

            v = new vehicle();
            v.owner = "John (Regular User)";
            v.registration = "ee55 eee";
            v.make = "Ducati";
            v.model = "Monster";
            v.type = "Motorbike";
            vehicles.Add(v);
        }

        public List<string> getRegDetails()
        {
            List<string> ret = new List<string>();
            for (int i = 0; i < vehicles.Count; i++){
                if (vehicles.ElementAt(i).owner.Equals(currentOwner))
                {
                    ret.Add(vehicles.ElementAt(i).registration);
                }
            }
            return ret;
        }

        public List<string> getSpecificVehicleDetails(string reg)
        {
            List<string> ret = new List<string>();
            for (int i = 0; i < vehicles.Count; i++)
            {
                if (vehicles.ElementAt(i).registration.Equals(reg))
                {
                    ret.Add(vehicles.ElementAt(i).make);
                    ret.Add(vehicles.ElementAt(i).model);
                    ret.Add(vehicles.ElementAt(i).type);
                }
            }
            return ret;
        }

    }// class
}// ns
