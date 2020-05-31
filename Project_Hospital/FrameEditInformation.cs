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
    public partial class FrameEditInformation : Form
    {
        public FrameEditInformation()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public String tcno;
        Database database = new Database();
        private void FrameEditInformation_Load(object sender, EventArgs e)
        {

            MaskTC.Text = tcno;
            MySqlCommand command = new MySqlCommand("SELECT * FROM hospital.patient WHERE `patient tc no`=@p1", database.Connection());
            command.Parameters.AddWithValue("@p1",tcno);
            MySqlDataReader dr = command.ExecuteReader();
            while (dr.Read()) {

                TxtName.Text = dr[1].ToString();
                TxtSurname.Text = dr[2].ToString();
                MaskPhone.Text = dr[4].ToString();
                TxtPass.Text = dr[5].ToString();
                CmbGender.Text = dr[6].ToString();
            
            }

            database.Connection().Close();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            
            MySqlCommand command2 = new MySqlCommand("UPDATE `hospital`.`patient` SET `patient name`=@p1, `patient surname`=@p2,  `patient phone no`=@p4, " +
                " `patient password`=@p5, `patient gender`=@p6 WHERE ( `patient tc no` = @p3) ", database.Connection());
            command2.Parameters.AddWithValue("@p1", TxtName.Text);
            command2.Parameters.AddWithValue("@p2", TxtSurname.Text);
            command2.Parameters.AddWithValue("@p4", MaskPhone.Text);
            command2.Parameters.AddWithValue("@p5", TxtPass.Text);
            command2.Parameters.AddWithValue("@p6", CmbGender.Text);
            command2.Parameters.AddWithValue("@p3", MaskTC.Text);
            command2.ExecuteNonQuery();
            database.Connection().Close();
            MessageBox.Show("It Is updated your informations.!","Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }
    }
}
