using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChristmasMaze.Common.Enums;

namespace ChristmasMaze.Data.Interfaces
{
    public interface ICharacter
    {
        string Name { get; set; }
        CharacterType Type { get; set; }
        double HealthPoints { get; set; }
        double AttackPoints { get; set; }
        double DefensePoints { get; set; }
    }
}
