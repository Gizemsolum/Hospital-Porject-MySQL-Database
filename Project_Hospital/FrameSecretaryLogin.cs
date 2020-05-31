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
    public partial class FrameSecretaryLogin : Form
    {
        public FrameSecretaryLogin()
        {
            InitializeComponent();
        }

        Database database = new Database();
        private void BtnLogin_Click(object sender, EventArgs e)
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM hospital.secretary WHERE `secretary tc no`=@p1 AND `secretary password`=@p2 ", database.Connection());
            command.Parameters.AddWithValue("@p1", MaskTC.Text);
            command.Parameters.AddWithValue("@p2", TxtPass.Text);
            MySqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {

                FrameSecretaryDetail fr = new FrameSecretaryDetail();
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

        private void FrameSecretaryLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
