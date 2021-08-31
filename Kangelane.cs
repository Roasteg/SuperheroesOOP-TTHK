using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kangelased
{   
    class Kangelane
    {
        private string _name;
        private string _location;


        public Kangelane(string heroName, string heroLocation)
        {
            _name = heroName;
            _location = heroLocation;
        }



        public string GetNimi() { return _name; }
        public void SetNimi(string newName) { _name = newName; }

        public string GetLocation() { return _location; }

        public void SetLocation(string newLocation) { _location = newLocation; }

        public int SavedPeople(int people)
        {
            return people = ((int)(people * 0.95));
        }

        public override string ToString()
        {
            return $"{_name} kaitseb linna {_location}";
        }

    }
}
