using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTierBusiness;

namespace WinAppUI
{
    public class CustomerViewModel : INotifyPropertyChanged, ICustomerViewModel
    {
        private ICustomerBO _model;

        public ICustomerBO CustomerDataEntity
        {
            get
            {
                return _model;
            }
        }

        public Guid Id
        {
            get { return _model.Id; }
            set
            {
               // read only
            }
        }

        public string Name
        {
            get { return _model.Name; }
            set
            {
                _model.Name = value;
                this.NotifyPropertyChanged("Name");
            }
        }

        public int Age
        {
            get { return _model.Age; }
            set
            {
                _model.Age = value;
                this.NotifyPropertyChanged("Age");
            }
        }

        public CustomerViewModel(ICustomerBO model)
        {
            _model = model;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
