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
    public partial class FrameDepartmentPanel : Form
    {
        public FrameDepartmentPanel()
        {
            InitializeComponent();
        }

        Database database = new Database();
        private void FrameDepartmentPanel_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            MySqlDataAdapter mysql = new MySqlDataAdapter("SELECT * FROM hospital.department",database.Connection());
            mysql.Fill(dt);
            dataGridView1.DataSource =dt;   

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int selected = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            TxtDeptName.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            MySqlCommand command = new MySqlCommand("INSERT INTO `hospital`.`department` (`department name`) VALUES (@p1)", database.Connection());
            command.Parameters.AddWithValue("@p1", TxtDeptName.Text);
            command.ExecuteNonQuery();
            database.Connection().Close();
            MessageBox.Show("It has been added the department", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            MySqlCommand command2 = new MySqlCommand("DELETE FROM `hospital`.`department` WHERE `department id`=@p1", database.Connection());
            command2.Parameters.AddWithValue("@p1", TxtId.Text);
            command2.ExecuteNonQuery();
            database.Connection().Close();
            MessageBox.Show("It has been deleted the department", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            MySqlCommand command3 = new MySqlCommand("UPDATE `hospital`.`department` SET `department name` = @p1 WHERE (`department id` = @p2)", database.Connection());
            command3.Parameters.AddWithValue("@p1", TxtDeptName.Text);
            command3.Parameters.AddWithValue("@p2", TxtId.Text);
            command3.ExecuteNonQuery();
            database.Connection().Close();
            MessageBox.Show("It has been updated the department", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
