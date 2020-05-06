using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeFitness.Common
{
    public static class Util
    {
        public static void RemoveUnderscoreFromColumns(this DataColumnCollection dts)
        {
            foreach (DataColumn col in dts)
            {
                col.ColumnName = col.ColumnName.Replace('_', ' ');
            };
        }
    }
}
