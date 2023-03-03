using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using Telegim.Monitor.ViewModels;
using WpfCronometro.Model;

namespace WpfCronometro.ViewModels
{
    public class CronometroVM: Control
       {
        public CronometroVM()
        {
            Chronometer= new Cronometro();
            CronometroTimer = new DispatcherTimer();
            CronometroTimer.Interval = TimeSpan.FromSeconds(1);
            CronometroTimer.Tick += CronometroTimer_Tick;
            SetCommands();
        }

       
        public DispatcherTimer CronometroTimer { get; set; }

        public Cronometro Chronometer { get; set; }

        public ICommand StartCronometro { get; private set; }
        public ICommand PauseCronometro { get; private set; }
        public ICommand StopCronometro { get; private set; }

        private void SetCommands()
        {
            StartCronometro = new RelayCommand(p =>  true, p => ExecuteStartCronometro());
            PauseCronometro = new RelayCommand(p => true, p => ExecutePauseCronometro());
            StopCronometro = new RelayCommand(p => true, p => ExeccuteStopCronometro());
        }

        private void ExeccuteStopCronometro()
        {
            CronometroTimer.Stop();
            Chronometer.InitCurrentTime();
        }

        private void ExecutePauseCronometro()
        {
            CronometroTimer.Stop();
        }

        private void ExecuteStartCronometro()
        {
            CronometroTimer.Start();
        }

        private void CronometroTimer_Tick(object? sender, EventArgs e)
        {
            Chronometer.RefreshSeconds();
        }
      
    }
}
