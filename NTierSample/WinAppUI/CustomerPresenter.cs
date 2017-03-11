using System;
using NTierBusiness;
using NTierBusiness.Services;

namespace WinAppUI
{
    public class CustomerPresenter : WinAppUI.ICustomerPresenter
    {
        private ICustomerViewModel _viewModel;
        private ICustomerView _view;
        private ICustomerBOService _service;

        public CustomerPresenter(ICustomerView view, ICustomerBOService service)
        {
            _view = view;
            _service = service;
        }

        public void CloseClicked()
        {
            _view.Close();
        }

        public void LoadClicked()
        {
            try
            {
                ICustomerBO customerBo = _service.CreateNew();

                _viewModel = new CustomerViewModel(customerBo);

                _view.ShowCustomer(_viewModel);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.ToString());
            }    
        }

        public void SaveClicked()
        {
            try
            {
                _view.ReadUserInput();

                ICustomerBO customerDataEntity = _viewModel.CustomerDataEntity;
                bool duplicateExist = !IsDuplicateOfExisting(customerDataEntity);
                if (duplicateExist)
                {
                    _service.Save(customerDataEntity);
                    _view.Close();
                }
                else
                {
                    _view.ShowError(string.Format("Customer '{0}' already exist", _viewModel.Name));
                }
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.ToString());
            }          
        }

        private bool IsDuplicateOfExisting(ICustomerBO newCustomerDataEntity)
        {
            ICustomerBO duplicateCustomerDataEntity = _service.GetCustomer(newCustomerDataEntity.Id);
            return duplicateCustomerDataEntity != null;
        }
    }
}
