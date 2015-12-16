using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChristmasMaze.Common.Enums;
using ChristmasMaze.Data.Interfaces;

namespace ChristmasMaze.Data.Classes
{
    public class Inventory : IInventory
    {
        private List<Item> items;

        public Inventory()
        {
            items = new List<Item>();
        }
        public List<Item> Items
        {
            get { return this.items; }
            set
            {
                throw new NotImplementedException();
            }
        }

        public double CalculateItemClassStats(ItemClass itemClass)
        {
            //switch (itemClass)
            //{
            //     case ItemClass.Weapon:   
            //
            return 0;
        }


        public void CollectItem(Item item)
        {
            this.Items.Add(item);
        }


        private double CalculateStats(List<Item> items)
        {
            foreach (var item in items)
            {

            }
        }
    }
}
