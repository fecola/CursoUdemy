using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Entities
{
    internal class HourContract
    {
        public DateTime Data { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }


        public double TotalValue()
        {

        }
    }
}
