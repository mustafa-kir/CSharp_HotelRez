using OtelRezarvasyon.Business.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezarvasyon
{
    public partial class EmployeePage : UserControl
    {
        private IEmployeeService _employeeService;
        public EmployeePage()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LoadEmployeePage();
        }

        private void LoadEmployeePage()
        {
           // lblEmployeeTasks.Text = Convert.ToString(_employeeService.GetEmployeeTasks()); // fonksiyon yanlış ve bir değer gönder.

        }
    }
}
