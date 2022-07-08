using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversitySystem.Classes;
using UniversitySystem.Services;

namespace UniversitySystem.WinApp.AdminForms
{
    public partial class RemoveRoom : Form
    {
        public RemoveRoom()
        {
            InitializeComponent();
            ServiceClass service = new ServiceClass();
            List<Room> rooms = new List<Room>();
            rooms = service.AllRoom();

            dgRooms.DataSource = rooms;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Close();
            admin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceClass service = new ServiceClass();

            int ID = Convert.ToInt32(txtID.Text);
            bool Result = service.RemoveRoom(ID);

            if (Result)
            {
                MessageBox.Show("Done!");
                txtID.ResetText();
            }
            else
            {
                MessageBox.Show("Faild!");
                txtID.ResetText();
            }
        }
    }
}
