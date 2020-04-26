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
        private int totalPoints;
        private Achievements achievements;


        User(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
            totalPoints = 0;
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

        public int GetTotalPoints()
        {
            return totalPoints;
        }

        public void addPoints (int point)
        {
            this.totalPoints += point;
        }

    }
}
