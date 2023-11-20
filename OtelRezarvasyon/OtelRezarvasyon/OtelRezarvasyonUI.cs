using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelRezarvasyon.Business.Abstract;

namespace OtelRezarvasyon.FormsUI
{
    public partial class OtelRezarvasyonUI : Form
    {
        private IBossService _bossService;
        private ICustomerService _customerService;
        private IEmployeeService _employeeService;
        private ILoginService _loginService;
        private IResponsibleEmployeeService _responsibleEmployeeService;
        public OtelRezarvasyonUI()
        {
            InitializeComponent();
        }

        private void OtelRezarvasyonUI_Load(object sender, EventArgs e)
        {
            loginPage1.BringToFront();
        }


    }
}
