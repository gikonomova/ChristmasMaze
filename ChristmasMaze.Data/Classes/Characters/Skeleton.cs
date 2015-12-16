using ChristmasMaze.Common.Enums;

namespace ChristmasMaze.Data.Classes.Characters
{
    public class Skeleton : Character
    {
        private const double SkeletonAttackPoints = 60;
        private const double SkeletonHealthPoints = 100;
        private const double SkeletonDefensePoints = 50;
        public Skeleton(string name, CharacterType type, double healthPoints, double attackPoints, double defensePoints)
            : base(name, type, SkeletonAttackPoints, SkeletonHealthPoints, SkeletonDefensePoints)
        {
            this.Name = name;
            this.Type = CharacterType.Skeleton;
        }
    }
}
