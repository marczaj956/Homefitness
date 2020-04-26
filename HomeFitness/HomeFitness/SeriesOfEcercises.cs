using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeFitness
{
    class SeriesOfEcercises
    {
       private List<Exercise> series;


        SeriesOfEcercises()
        {
            series = new List<Exercise>();
        }
        public void addExercise (Exercise exercise)
        {
            series.Add(exercise);
        }
        public void deleteExercise(Exercise exercise)
        {
            series.Remove(exercise);
        }
        public bool existExercise (Exercise exercise)
        {
           if( series.Find(Exercise =>Exercise.GetName() == exercise.GetName()) != null)
            {
                return false;
            }
           else
            {
                return true;
            }
        }

    }
}
