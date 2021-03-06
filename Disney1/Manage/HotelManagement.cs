﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disney1.Manage
{
    public partial class HotelManagement : UserControl
    {
        public HotelManagement()
        {
            InitializeComponent();
        }

        public void DataRefresh()
        {
            searchRoomToolStripMenuItem_Click(null, null);
        }

        private void searchRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchRoom1.DataRefresh();
            searchRoom1.BringToFront();
        }

        private void orderRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderRecord1.DataRefresh();
            orderRecord1.BringToFront();
        }

        private void hotelRepotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hotelReport21.DataRefresh();
            hotelReport21.BringToFront();
        }

        private void roomManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            roomManagement1.DataRefresh();
            roomManagement1.BringToFront();
        }

        private void guestManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guestManagement1.DataRefresh();
            guestManagement1.BringToFront();
        }

        private void generateTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateTicket1.DataRefresh();
            generateTicket1.BringToFront();
        }
    }
}
