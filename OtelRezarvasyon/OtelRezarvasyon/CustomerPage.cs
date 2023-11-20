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
    public partial class CustomerPage : UserControl
    {
        public int userId;
        private ICustomerService _customerService;
        private IReservedRoomsService _reservedRoomsService;
        private ILoginService _loginService;
        
        public CustomerPage()
        {
            InitializeComponent();
        }
       
        private void LoadCustomerPage()
        {
            dGWMusteriOdalar.DataSource = _customerService.GetAll();
            
            tBxUserName.Text = Convert.ToString(_loginService.GetAll(userId).Take(0)); // tümünü listele. Ekranın sağ tarafınıda datasource yap. 
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(tBxRoomCapacityFilter.Text))
                {
                    dGWMusteriOdalar.DataSource = _customerService.GetRoomsByRoomCapacity(Convert.ToInt32(tBxRoomCapacityFilter.Text));
                }
                if(!String.IsNullOrEmpty(tBxRoomDayPriceFilter.Text))
                {
                    dGWMusteriOdalar.DataSource = _customerService.GetRoomsByRoomDayPrice(Convert.ToInt32(tBxRoomDayPriceFilter.Text));
                }
                else
                {
                    LoadCustomerPage();
                }
            }
            catch 
            {                
            }
        }

        private void btnRoomReservation_Click(object sender, EventArgs e)
        {
            if(dGWMusteriOdalar.CurrentRow != null)
            {
                try
                {
                    _reservedRoomsService.Add(new ReservedRooms
                    {
                       RoomId = Convert.ToInt32(dGWMusteriOdalar.CurrentRow.Cells[0].Value),
                      // CustomerId =  // müşterinin adını alıp buraya kaydetme.
                    });
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }
            }

        }
    }
}
