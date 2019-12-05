using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5780_03_2088
{
    public class HostingUnit
    {
        private string unitName;
        private int rooms;
        private bool isSwimmimgPool;

        public string UnitName
        {
            get { return unitName; }
            set { unitName = value; }
        }

        public int Rooms   
        {
            get { return rooms; }
            set { rooms = value; }
        }

        public bool IsSwimmimgPool
        {
            get { return isSwimmimgPool; }
            set { isSwimmimgPool = value; }
        }

        public List<DateTime> AllOrders { get; set; } // list of orders for the unit
        public List<string> Uris { get; set; } // list of pictures links.

        public HostingUnit()
        {
            AllOrders = new List<DateTime>();
            Uris = new List<string>();
        }
    }
}
