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
    public partial class FrameDoctorEditInformation : Form
    {
        public FrameDoctorEditInformation()
        {
            InitializeComponent();
        }

        Database database = new Database();
        public String tc;
        private void FrameDoctorEditInformation_Load(object sender, EventArgs e)
        {

            MaskTC.Text = tc;
            MySqlCommand command = new MySqlCommand("SELECT * FROM hospital.doctors WHERE doctor_tc_no=@p1", database.Connection());
            command.Parameters.AddWithValue("@p1", tc);
            MySqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {

                TxtName.Text = dr[1].ToString();
                TxtSurname.Text = dr[2].ToString();
                CmbDept.Text = dr[4].ToString();
                TxtPass.Text = dr[5].ToString();

            }

            database.Connection().Close();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //transfer wrong department !!
            MySqlCommand command2 = new MySqlCommand("UPDATE `hospital`.`doctors` SET doctor_name=@p1, doctor_surname=@p2,  doctor_department=@p4, " +
               " doctor_password=@p5 WHERE doctor_tc_no = @p3 ", database.Connection());
            command2.Parameters.AddWithValue("@p1", TxtName.Text);
            command2.Parameters.AddWithValue("@p2", TxtSurname.Text);
            command2.Parameters.AddWithValue("@p4", CmbDept.Text);
            command2.Parameters.AddWithValue("@p5", TxtPass.Text);
            command2.Parameters.AddWithValue("@p3", MaskTC.Text);
            command2.ExecuteNonQuery();
            database.Connection().Close();
            MessageBox.Show("It Is updated your informations.!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
