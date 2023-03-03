using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCronometro.ViewModels;

namespace WpfCronometro.Model
{
    public class Cronometro : ViewModelBase, ICronometro, ITiempo
    {
        int horas = 0;
        int minutos = 0;
        int segundos = 0;
        double InernalSeconds = 0;

   
        public int Horas { get => horas; set => SetValue(ref horas, value, nameof(Horas)); }
        public int Minutos { get => minutos; set => SetValue(ref minutos, value, nameof(Minutos)); }
        public int Segundos { get => segundos; set => SetValue(ref segundos, value, nameof(Segundos)); }

        public void InitCurrentTime()
        {
            InernalSeconds = 0;
            RefreshHora();
        }
        public void RefreshSeconds()
        {
            InernalSeconds += 1;
            RefreshHora();
           
        }


        void RefreshHora()
        {
            Segundos = TimeSpan.FromSeconds(InernalSeconds).Seconds;
            Minutos = TimeSpan.FromSeconds(InernalSeconds).Minutes;
            Horas = TimeSpan.FromSeconds(InernalSeconds).Hours;
        }
    }
}
