using ChristmasMaze.Common.Enums;

namespace ChristmasMaze.Data.Classes.Characters
{
    public class Elf : Character
    {
        private const double ElffAttackPoints = 45;
        private const double ElffHealthPoints = 175;
        private const double ElfDefensePoints = 80;
        public Elf(string name, CharacterType type, double healthPoints, double attackPoints, double defensePoints)
            : base(name, type, ElffAttackPoints, ElffHealthPoints, ElfDefensePoints)
        {
            this.Name = name;
            this.Type = CharacterType.Elf;

        }
    }
}
