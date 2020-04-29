using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeFitness
{
    class Exercise
    {
        private int amount;
        private int calories;
        private string description;
        private string exercisedMuscles;
        private string name;
        private int points;
        private Category category;
   

        Exercise(int amount, int calories, int points, string description, string exercisedMuscles, string name, Category category)
        {
            this.amount = amount;
            this.calories = calories;
            this.points = points;
            this.description = description;
            this.exercisedMuscles = exercisedMuscles;
            this.name = name;
            this.category = category;
        }

        public void SetAmount(int amount)
        {
            this.amount = amount;
        }

        public int GetAmount()
        {
            return amount;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetCalories(int calories)
        {
            this.calories = calories;
        }

        public int GetCalories()
        {
            return calories;
        }

        public void SetPoints(int points)
        {
            this.points = points;
        }

        public int GetPoints()
        {
            return points;
        }

        public void SetDescription(String description)
        {
            this.description = description;
        }

        public string GetDescription()
        {
            return description;
        }

        public int getTotalCalories()
        {
            return amount * calories;
        }
        public int getTotalPoint()
        {
            return amount * points;
        }
    }
}
