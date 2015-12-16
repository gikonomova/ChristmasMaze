using ChristmasMaze.Common.Enums;

namespace ChristmasMaze.Data.Classes.Characters
{
    public class Dwarf : Character
    {
        private const double DwarfAttackPoints = 30;
        private const double DwarfHealthPoints = 120;
        private const double DwarfDefensePoints = 100;
        public Dwarf(string name, CharacterType type, double healthPoints, double attackPoints, double defensePoints)
            : base(name, type, DwarfAttackPoints, DwarfHealthPoints, DwarfDefensePoints)
        {
            this.Name = name;
            this.Type = CharacterType.Dwarf;
            
        }
    }
}
