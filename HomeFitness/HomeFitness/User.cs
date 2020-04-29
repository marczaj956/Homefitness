using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeFitness
{
    class User
    {
        private string name;
        private int weight;
       // private int totalPoints PAMIETAĆ ŻEBY POCIĄGNĄĆ Z NOTATNIKA
        private Achievements achievements;


        User(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
            achievements = Achievements.BEGINNER;
        }


        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetWeight(int weight)
        {
            this.weight = weight;
        }

        public int getWeight()
        {
            return weight;
        }

    }
}
