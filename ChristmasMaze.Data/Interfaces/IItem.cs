using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChristmasMaze.Common.Enums;

namespace ChristmasMaze.Data.Interfaces
{
    public interface IItem
    {
        string Name { get; set; }
        ItemType Type { get; set; }
        double AttackPoints { get; set; }
        double DefensePoints { get; set; }
        void CalculateItemTypeBonus();
    }
}
