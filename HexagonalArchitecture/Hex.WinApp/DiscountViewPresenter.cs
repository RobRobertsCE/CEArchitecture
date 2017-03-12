using System;
using System.ComponentModel;

namespace Hex.WinApp
{
    internal class DiscountViewPresenter : INotifyPropertyChanged, IDiscountViewPresenter
    {
        private readonly DiscountViewAdapter _adapter;
        private readonly IDiscountView _view;

        private DiscountViewModel _model;
        public DiscountViewModel Model
        {
            get
            {
                return _model;
            }
        }

        public double Amount
        {
            get
            {
                return _model.Amount;
            }
            set
            {
                _model.Amount = value;
                OnPropertyChanged("Amount");
            }
        }
        public double Discount
        {
            get
            {
                return _model.Discount;
            }
            set
            {
                _model.Discount = value;
                OnPropertyChanged("Discount");
                OnPropertyChanged("Total");
            }
        }
        public double Total
        {
            get
            {
                return Amount - Discount;
            }
        }

        public DiscountViewPresenter(IDiscountView view)
        {
            _view = view;
            _adapter = new DiscountViewAdapter();
            _model = new DiscountViewModel();
        }

        public void GetRate()
        {
            try
            {
                _view.ReadValues();
                Discount = _adapter.GetRate(Amount);
            }
            catch (Exception ex)
            {
                _view.DisplayError(ex.Message);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (null != PropertyChanged)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
