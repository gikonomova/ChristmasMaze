using ChristmasMaze.Common.Enums;

namespace ChristmasMaze.Data.Classes.Characters
{
    public class Wolf : Character
    {
        private const double WolfAttackPoints = 50;
        private const double WolfHealthPoints = 180;
        private const double WolfDefensePoints = 100;
        public Wolf(string name, CharacterType type, double healthPoints, double attackPoints, double defensePoints)
            : base(name, type, WolfAttackPoints, WolfHealthPoints, WolfDefensePoints)
        {
            this.Name = name;
            this.Type = CharacterType.Wolf;
        }
    }
}
