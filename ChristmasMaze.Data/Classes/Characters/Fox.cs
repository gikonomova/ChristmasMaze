using ChristmasMaze.Common.Enums;

namespace ChristmasMaze.Data.Classes.Characters
{
    public class Fox : Character
    {
        private const double FoxAttackPoints = 30;
        private const double FoxHealthPoints = 150;
        private const double FoxDefensePoints = 75;
        public Fox(string name, CharacterType type, double healthPoints, double attackPoints, double defensePoints)
            : base(name, type, FoxHealthPoints, FoxAttackPoints, FoxDefensePoints)
        {
            this.Name = name;
            this.Type = CharacterType.Fox;

        }
    }
}
