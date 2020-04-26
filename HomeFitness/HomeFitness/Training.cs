using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeFitness
{
    class Training
    {
       private List<SeriesOfEcercises> training;
       private DateTime date;
       private TimeSpan duration;

        Training(DateTime date)
        {
            this.date = date;
        }
        public void SetDate(DateTime date)
        {
            this.date = date;
        }
        public DateTime GetDate()
        {
            return date;
        }

        public void addSeries(SeriesOfEcercises series)
        {
            training.Add(series);
        }

        
    }
}
