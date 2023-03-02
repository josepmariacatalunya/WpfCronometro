using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCronometro.Model
{
    internal class Cronometro : Tiempo, ICronometro
    {
        public TimeOnly InitTime { get; set; }
        public TimeOnly EndTime { get; set; }

    }
}
