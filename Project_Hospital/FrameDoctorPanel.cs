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
    public partial class FrameDoctorPanel : Form
    {
        public FrameDoctorPanel()
        {
            InitializeComponent();
        }

        Database database = new Database();
        private void FrameDoctorPanel_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            MySqlDataAdapter mySqlData = new MySqlDataAdapter("SELECT *  FROM hospital.doctors", database.Connection());
            mySqlData.Fill(dt);
            dataGridView1.DataSource = dt;

            MySqlCommand command2 = new MySqlCommand("SELECT `department name` FROM hospital.department ", database.Connection());
            MySqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {

                CmbDept.Items.Add(dr2[0]);

            }

            database.Connection().Close();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            MySqlCommand command = new MySqlCommand("INSERT INTO `hospital`.`doctors` (`doctor name`, `doctor surname`, `doctor department`, `doctor tc no`, `doctor password`) VALUES (@p1,@p2,@p3,@p4,@p5)",database.Connection());
            command.Parameters.AddWithValue("@p1",TxtName.Text);
            command.Parameters.AddWithValue("@p2",TxtSurname.Text);
            command.Parameters.AddWithValue("@p3", CmbDept.Text);
            command.Parameters.AddWithValue("@p4", MskTC.Text);
            command.Parameters.AddWithValue("@p5", TxtPass.Text);
            command.ExecuteNonQuery();
            database.Connection().Close();
            MessageBox.Show("It has been added the doctor","Information",MessageBoxButtons.OK);

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
           
            MySqlCommand command3= new MySqlCommand("DELETE FROM `hospital`.`doctors` WHERE `doctor tc no`=@p1", database.Connection());
            command3.Parameters.AddWithValue("@p1", MskTC.Text);
            command3.ExecuteNonQuery();
            database.Connection().Close();
            MessageBox.Show("It has been deleted the doctor", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int selected = dataGridView1.SelectedCells[0].RowIndex;
            TxtName.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            CmbDept.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            MskTC.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            TxtPass.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
                                                                                                                
            MySqlCommand command3 = new MySqlCommand("UPDATE `hospital`.`doctors` SET `doctor name` = @p1, `doctor surname` = @p2, " +
                "`doctor department` = @p3, `doctor password` = @p5 WHERE (`doctor tc no` = @p4)", database.Connection());
            command3.Parameters.AddWithValue("@p1", TxtName.Text);
            command3.Parameters.AddWithValue("@p2", TxtSurname.Text);
            command3.Parameters.AddWithValue("@p3", CmbDept.Text);
            command3.Parameters.AddWithValue("@p5", TxtPass.Text);
            command3.Parameters.AddWithValue("@p4", MskTC.Text);
            command3.ExecuteNonQuery();
            database.Connection().Close();
            MessageBox.Show("It has been updated the doctor", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
