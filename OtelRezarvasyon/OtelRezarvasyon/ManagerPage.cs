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
    public partial class ManagerPage : UserControl
    {
        private IBossService _bossService;
        public ManagerPage()
        {
            InitializeComponent();
        }

        private void OtelRezarvasyonUI_Load()
        {
            LoadRooms();
        }

        private void LoadRooms()
        {
            dgvMusteriOdalar.DataSource = _bossService.GetAll();
        }

        private void btnRoomAdd_Click(object sender, EventArgs e)
        {
            _bossService.Add(new Room
            {
                // form daki tabloda bir danışman onay durumu yok
                RoomNumber = Convert.ToInt32(tBxAddRoomNumber.Text),
                NumberOfGuests = Convert.ToInt32(tBxAddRoomCapacity.Text),
                DateRange = Convert.ToDateTime( tBxAddRoomDate.Text),
                RoomDayRate = Convert.ToInt32(tBxAddRoomPrice.Text),
                ResponsibleEmployee = tBxAddRoomResponsible.Text
            }) ;
        }

        private void btnRoomDelete_Click(object sender, EventArgs e)
        {
            if (dgvMusteriOdalar.CurrentRow != null)
            {
                try
                {
                    _bossService.Delete(new Room
                    {
                        RoomId = Convert.ToInt32(dgvMusteriOdalar.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Ürün silindi!");
                    LoadRooms();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }

        }

        private void btnRoomUpdate_Click(object sender, EventArgs e)
        {
            _bossService.Update(new Room
            {
                RoomId = Convert.ToInt32(dgvMusteriOdalar.CurrentRow.Cells[0].Value),
                RoomNumber = Convert.ToInt32(tBxUpdateRoomNumber.Text),
                NumberOfGuests = Convert.ToInt32(tBxUpdateRoomCapacity.Text),
                DateRange = Convert.ToDateTime(tBxUpdateRoomDate),
                //ConfirmationStatus =
                ResponsibleEmployee = tBxUpdateResponsible.Text,
                RoomDayRate = Convert.ToInt32(tBxUpdateRoomPrice.Text)
            });
        }
    }
}
