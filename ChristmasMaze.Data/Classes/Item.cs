using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChristmasMaze.Common.Enums;
using ChristmasMaze.Data.Interfaces;

namespace ChristmasMaze.Data.Classes
{
    public class Item : IItem
    {
        private string name;
        private ItemType type;
        private double attackPoints;
        private double defensePoints;

        public Item(string name, ItemType type, double attackPoints, double defensePoints)
        {
            this.Name = name;
            this.Type = type;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
        }
        public string Name
        {
            get
            {
                return  this.Name;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public ItemType Type
        {
            get { return this.Type; }
            set
            {
                throw new NotImplementedException();
            }
        }

        public double AttackPoints
        {
            get { return this.AttackPoints; }
            set
            {
                throw new NotImplementedException();
            }
        }

        public double DefensePoints
        {
            get { return this.DefensePoints; }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void CalculateItemTypeBonus()
        {
            switch (Type)
            {
                case ItemType.Normal:
                    this.AttackPoints += 1;
                    this.DefensePoints += 1;
                    break;
                case ItemType.Magic:
                    this.AttackPoints += 2;
                    this.DefensePoints += 2;
                    break;
                case ItemType.Rare:
                    this.AttackPoints += 4;
                    this.DefensePoints += 3;
                    break;
                case ItemType.Unique:
                    this.AttackPoints += 10;
                    this.DefensePoints += 8;
                    break;
            }
        }
    }
}
