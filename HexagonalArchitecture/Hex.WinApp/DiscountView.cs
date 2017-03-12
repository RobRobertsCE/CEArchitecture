using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hex.WinApp
{
    public partial class DiscountView : Form, IDiscountView
    {
        private readonly IDiscountViewPresenter _presenter;

        public DiscountView()
        {
            InitializeComponent();
            _presenter = new DiscountViewPresenter(this);
            PresenterBindingSource.DataSource = _presenter;
        }

        public void ReadValues()
        {
            PresenterBindingSource.EndEdit();
        }

        public void DisplayError(string message)
        {
            MessageBox.Show(message);
            Console.WriteLine(message);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                _presenter.GetRate();
            }
            catch (Exception ex)
            {
                DisplayError(ex.Message);
            }            
        }
    }
}
