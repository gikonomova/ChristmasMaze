using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChristmasMaze.Common.Enums;
using ChristmasMaze.Data.Classes;

namespace ChristmasMaze.Data.Interfaces
{
    public interface IInventory
    {
        List<Item> Items { get; set; }
        double CalculateItemClassStats(ItemClass itemClass);
        void CollectItem(Item item);
    }
}
