using System;

namespace WpfCronometro.Model
{
    internal interface ICronometro
    {
        TimeOnly EndTime { get; set; }
        TimeOnly InitTime { get; set; }
    }
}