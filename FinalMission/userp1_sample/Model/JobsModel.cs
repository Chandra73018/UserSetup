using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using userp1_sample.Base;

namespace userp1_sample.Model
{
    class JobsModel
    {
    }

    class Job : INotifyPropertyChanged
    {
        private string jobName;
        public string JobName
        {
            get
            {
                return jobName;
            }
            set
            {
                jobName = value;
                OnPropertyChanged("JobName");
            }
        }


        private bool checkall;
        public bool Checkall
        {
            get
            {
               
                return checkall;
            }
            set
            {
                checkall = value;
                OnPropertyChanged("Checkall");
            }
        }

        private string unjobs;
        public string Unjobs
        {
            get
            {
                return unjobs;
            }
            set
            {
                unjobs = value;
                OnPropertyChanged("Unjobs");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
