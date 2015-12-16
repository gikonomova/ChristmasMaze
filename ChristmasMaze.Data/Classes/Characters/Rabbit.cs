using ChristmasMaze.Common.Enums;

namespace ChristmasMaze.Data.Classes.Characters
{
    public class Rabbit : Character
    {
        private const double RabbitAttackPoints = 15;
        private const double RabbitHealthPoints = 165;
        private const double RabbitDefensePoints = 75;

        public Rabbit(string name, CharacterType type, double healthPoints, double attackPoints, double defensePoints)
            : base(name, type, RabbitAttackPoints, RabbitHealthPoints, RabbitDefensePoints)
        {
            this.Name = name;
            this.Type = CharacterType.Rabbit;
        }
    }
}
