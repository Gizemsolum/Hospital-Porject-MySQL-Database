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
    public partial class FramePatientSignUp : Form
    {
        public FramePatientSignUp()
        {
            InitializeComponent();
        }

        Database database = new Database();

        private void BtnRegister_Click(object sender, EventArgs e)
        {
         
                MySqlCommand command = new MySqlCommand("INSERT INTO `hospital`.`patient` (`patient name`, `patient surname`, `patient tc no`, `patient phone no`, `patient password`, `patient gender`) " +
                    "VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", database.Connection());
                command.Parameters.AddWithValue("@p1", TxtName.Text);
                command.Parameters.AddWithValue("@p2", TxtSurname.Text);
                command.Parameters.AddWithValue("@p3", MaskTC.Text);
                command.Parameters.AddWithValue("@p4", MaskPhone.Text);
                command.Parameters.AddWithValue("@p5", TxtPass.Text);
                command.Parameters.AddWithValue("@p6", CmbGender.Text);
                command.ExecuteNonQuery();
                database.Connection().Close();
                MessageBox.Show("Your registration has been done.Your Password: " + TxtPass.Text
                    , "Informaiton", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
