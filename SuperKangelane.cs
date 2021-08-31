using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kangelased
{
    class SuperKangelane : Kangelane
    {
        private double _agility;
        private static readonly Random _randomAgility = new Random();
        public SuperKangelane(string heroName, string heroLocation) : base(heroName, heroLocation)
        {
            _agility = _randomAgility.NextDouble() * (5-1) + 1;
        }

        public int SavedPeople(int people)
        {
            return Convert.ToInt32(people * (0.95 + (_agility / 100)));
        }

        public override string ToString()
        {
            return base.ToString()+$"\nLisaks on ta {_agility:N2}";
        }
    }
}
