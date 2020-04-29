using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeFitness
{
    class Training
    {
       private int idTraining; 
       private List<SeriesOfEcercises> training;
       private DayOfWeek day;
       private TimeSpan time;
       private TimeSpan duration;

        Training(int id, DayOfWeek day, TimeSpan time)
        {
            this.idTraining = id;
            this.day = day;
            this.time = time;
        }
        public void SetDate(DayOfWeek day)
        {
            this.day = day;
        }
        public DayOfWeek GetDay()
        {
            return day;
        }
        public void SetTime(TimeSpan time)
        {
            this.time = time;
        }
        public TimeSpan GetTime()
        {
            return time;
        }
        public void addSeries(SeriesOfEcercises series)
        {
            training.Add(series);
        }

        
    }
}
