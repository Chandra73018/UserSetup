using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using userp1_sample.Model;
using userp1_sample.Views;
using System.Collections.ObjectModel;
using userp1_sample.Base;
using System.Windows.Input;
using System.Windows.Controls;

namespace userp1_sample.ViewModel
{
    class JobsViewModel
    {
        public string text;
        private IList<Job> _JobsList;

        public void LoadJobs()
        {
            _JobsList = new List<Job>
            {
                new Job{JobName="Ready to Scan"},
                new Job{JobName="Ready to Scan - test"},
                new Job{JobName="Ready to Scan - test2"},
                new Job{JobName="Scan to PDF"},
                new Job{JobName="Scan to e-mail"},
            };
        }
        public IList<Job> Jobs
        {
            get { return _JobsList; }
            set { _JobsList = value; }
        }

        public JobsViewModel()
        {
            this.Activation = new RelayCommand<object>(o => SelExecute(), o => CanExecute());
            this.DeActivation = new RelayCommand<object>(o => DeselExecute(), o => CanExecute());
            this.SayOk = new RelayCommand<object>(o => Check(), o => CanExecute());

            LoadJobs();
         
        }
        
        public void SelExecute()
        {
            foreach (var a in Jobs)
            {
                a.Checkall = true;
            }
        }
        public void DeselExecute()
        {
            foreach (var a in Jobs)
            {
                a.Checkall = false;
            }
        }
        public void Check()
        {
           
            foreach (var a in Jobs)
            {
                if(a.Checkall == false)
                {
                    a.Unjobs = a.JobName;
                    text = a.Unjobs;
                }
            }
            
            Window1 owin2 = new Window1(text);
            owin2.Show();
        }
        private bool CanExecute()
        {
            return true;
        }
        public ICommand Activation
        {
            get;
            set;
        }
        public ICommand DeActivation
        {
            get;
            set;
        }
        public ICommand SayOk
        {
            get;
            set;
        }
       
    }
}
