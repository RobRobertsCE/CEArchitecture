using System;

namespace Hex.WinApp
{
    interface IDiscountViewPresenter
    {
        double Amount { get; set; }
        double Discount { get; set; }
        void GetRate();
        DiscountViewModel Model { get; }
        event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        double Total { get; }
    }
}
