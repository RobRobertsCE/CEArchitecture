using System;
using System.Windows.Forms;
using NTierBusiness.Services;

namespace WinAppUI
{
    public partial class CustomerView : Form, ICustomerView
    {
        private ICustomerPresenter _presenter;

        public CustomerView(ICustomerBOService service)
        {
            InitializeComponent();

            _presenter = new CustomerPresenter(this, service);
        }

        public CustomerView()
            : this(new CustomerBOService())
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _presenter.CloseClicked();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            _presenter.LoadClicked();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _presenter.SaveClicked();
        }

        public void ShowCustomer(ICustomerViewModel customerViewModel)
        {
            ViewModelBindingSource.DataSource = customerViewModel;
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ReadUserInput()
        {
            ViewModelBindingSource.EndEdit();
        }
    }
}
