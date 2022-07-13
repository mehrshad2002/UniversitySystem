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
    public partial class AddCollege : Form
    {
        public AddCollege()
        {
            InitializeComponent();

            ServiceClass service = new ServiceClass();
            List<Univercity> AllUnivercityList = service.ReadAllUnivercity();

            foreach (var item in AllUnivercityList)
            {
                comboBoxAllCollege.Items.Add(item.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            College college = new College();
            ServiceClass service = new ServiceClass();
            Random random = new Random();

            string FindUnivercityID = comboBoxAllCollege.Text;
            int UnivercityID = Convert.ToInt32(service.FindUnivercityID(FindUnivercityID));
            if( UnivercityID == 0)
            {
                MessageBox.Show("Faild");
                txtName.ResetText();
                comboBoxAllCollege.ResetText();
            }
            else
            {
                college.UnivercityID = UnivercityID;
                college.Id = random.Next(40,70);
                college.Name = txtName.Text;

                bool Result = service.AddCollege(college);
                if( Result == true)
                {
                    MessageBox.Show("Done");
                    txtName.ResetText();
                    comboBoxAllCollege.ResetText();
                }
                else
                {
                    MessageBox.Show("Faild");
                    txtName.ResetText();
                    comboBoxAllCollege.ResetText();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Close();
            admin.Show();
        }
    }
}
