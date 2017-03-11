using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Owin.Hosting;

namespace NTierRestAPI
{
    public partial class CustomerRestApiUI : Form
    {
        IDisposable _api;

        public CustomerRestApiUI()
        {
            InitializeComponent();
        }

        private void CustomerRestApiUI_Load(object sender, EventArgs e)
        {
            StartCustomerRestApi();
        }

        private void StartCustomerRestApi()
        {
            try
            {
                _api = WebApp.Start<Startup>("http://localhost:8080");
                DisplayMessage("Web Server is running.");
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.ToString());
            }
        }

        private void DisplayMessage(string message)
        {
            txtMessages.AppendText(message + "\r\n");
            txtMessages.SelectionStart = txtMessages.TextLength;
            txtMessages.ScrollToCaret();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (null != _api)
                _api.Dispose();
        }

    }
}
