using ContaBlazor.Shared.ItemModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Telegim.Monitor.ViewModels;
using WpfCronometro.Model;

namespace WpfCronometro.ViewModels
{
    public class CronometroVM: inotifypropertyobject
       {
        public CronometroVM()
        {
        }
        public Tiempo CurrentTime { get; set; }
        public  Timer CronometroTimer { get; set; }



        public ICommand StartCronometro

        {
            get { return (int)GetValue(StartCronometroProperty); }
            set { SetValue(StartCronometroProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StartCronometroProperty =
            DependencyProperty.Register("StartCronometro", typeof(int), typeof(CronometroVM), new PropertyMetadata(StartCronometroCall()));

      

        private static object StartCronometroCall()
        {
            throw new NotImplementedException();
        }

        //public RelayCommand StartCronometro => ExecuteStartCronometro();
        //public RelayCommand StopCronometro => ExecuteStopCronometro();
        //public RelayCommand PauseCronometro => ExecutePauseCronometro();

        //#region "ProcedimientosPrivados"

        //private RelayCommand ExecuteStopCronometro()
        //{
        //    throw new NotImplementedException();
        //}

        //private RelayCommand ExecutePauseCronometro()
        //{
        //    throw new NotImplementedException();
        //}

        //private RelayCommand ExecuteStartCronometro()
        //{
        //    throw new NotImplementedException();
        //}
        //#endregion
    }
}
