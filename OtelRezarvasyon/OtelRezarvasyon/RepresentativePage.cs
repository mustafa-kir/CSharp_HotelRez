using OtelRezarvasyon.Business.Abstract;
using OtelRezarvasyon.Entities.Concrete;
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
    public partial class RepresentativePage : UserControl
    {
        private IResponsibleEmployeeService _responsibleEmployeeService;
        public RepresentativePage()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LoadRepresentativePage();
        }

        private void LoadRepresentativePage()
        {
            dGWMusteriOdalar.DataSource = _responsibleEmployeeService.GetAll(); // müşteri idsine göre onaylat.
        }

        private void dGVMusteriOdalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            if (dGWMusteriOdalar.CurrentRow != null)
            {
                if (!Convert.ToBoolean(dGWMusteriOdalar.CurrentRow.Cells[2]))
                {
                    _responsibleEmployeeService.Update(new ReservedRooms
                    {
                        RoomConfirm = true
                    });
                }
                else
                {
                    _responsibleEmployeeService.Update(new ReservedRooms
                    {
                        RoomConfirm = false
                    });
                }
               
            }
        }
    }
}
