using System;
using NTierBusiness;

namespace WinAppUI
{
    public interface ICustomerViewModel
    {
        ICustomerBO CustomerDataEntity { get; }

        int Age { get; set; }
        Guid Id { get; set; }
        string Name { get; set; }
        event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    }
}
