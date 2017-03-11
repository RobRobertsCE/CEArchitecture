
namespace WinAppUI
{
    public interface ICustomerView
    {
        void ShowCustomer(ICustomerViewModel customerViewModel);
        void ShowError(string message);
        void ReadUserInput();
        void Close();
    }
}
