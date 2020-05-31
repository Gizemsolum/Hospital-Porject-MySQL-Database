using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_Hospital
{
    public partial class FrameDoctorLogin : Form
    {
        public FrameDoctorLogin()
        {
            InitializeComponent();
        }

        Database database = new Database();
        private void BtnLogin_Click(object sender, EventArgs e)
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM hospital.doctors WHERE doctor_tc_no=@p1 AND doctor_password=@p2 ", database.Connection());
            command.Parameters.AddWithValue("@p1", MaskTC.Text);
            command.Parameters.AddWithValue("@p2", TxtPass.Text);
            MySqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {

                FrameDoctorDetail fr = new FrameDoctorDetail();
                fr.tc = MaskTC.Text;
                fr.Show();
                this.Hide();

            }
            else
            {

                MessageBox.Show("You are entered wrong TC or Password!");

            }

            database.Connection().Close();

        }

    }
}
