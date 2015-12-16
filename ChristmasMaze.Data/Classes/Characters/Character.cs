using System;
using ChristmasMaze.Data.Interfaces;
using ChristmasMaze.Common.Enums;

namespace ChristmasMaze.Data.Classes.Characters
{
    public abstract class Character : ICharacter
    {
        private string name;
        private CharacterType type;
        private double healtPoints;
        private double attackPoints;
        private double defensePoints;

        protected Character(string name, CharacterType yype, double healthPoints, double attackhPoints, double defensehPoints)
        {
            this.Name = name;
            this.Type = type;
            this.HealthPoints = healthPoints;
            this.AttackPoints = attackhPoints;
            this.DefensePoints = defensehPoints;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }
            }
        }

        public CharacterType Type
        {
            get { return this.type; }
            set
            {
                if (value != CharacterType.Dwarf ||
                    value != CharacterType.Elf ||
                    value != CharacterType.Fox ||
                    value != CharacterType.Skeleton ||
                    value != CharacterType.Rabbit ||
                    value != CharacterType.Wolf)
                {
                    throw new ArgumentException("Unknown type!");
                }
            }
        }

        public double HealthPoints
        {
            get { return this.healtPoints; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Health Points cannot be null or negative!");
                }
            }
        }

        public double AttackPoints
        {
            get { return this.attackPoints; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Attack Points cannot be null or negative!");
                }
            }
        }

        public double DefensePoints
        {
            get { return this.defensePoints; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Defense Points cannot be null or negative!");
                }
            }
        }
    }
}
