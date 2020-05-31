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
    public partial class FrameDoctorDetail : Form
    {
        public FrameDoctorDetail()
        {
            InitializeComponent();
        }

        Database database = new Database();
        public String tc;
        private void FrameDoctorDetail_Load(object sender, EventArgs e)
        {

            LblTC.Text = tc;
            MySqlCommand command = new MySqlCommand("SELECT doctor_name, doctor_surname FROM hospital.doctors WHERE doctor_tc_no=@p1", database.Connection());
            command.Parameters.AddWithValue("@p1", LblTC.Text);
            MySqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {

                LblNameSurname.Text = dr[0] + " " + dr[1];

            }

            database.Connection().Close();

            DataTable dt = new DataTable();
            MySqlCommand command2 = new MySqlCommand("SELECT * FROM hospital.appointment WHERE appointment_doctor=@p1", database.Connection());
            command2.Parameters.AddWithValue("@p1",LblNameSurname.Text);
            MySqlDataAdapter mySqlData = new MySqlDataAdapter(command2);
            mySqlData.Fill(dt);
            dataGridView1.DataSource = dt;

           

        }

        private void BtnAnnouncements_Click(object sender, EventArgs e)
        {

            FrameAnnouncements fr = new FrameAnnouncements();
            fr.Show();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            FrameDoctorEditInformation fr = new FrameDoctorEditInformation();
            fr.tc = LblTC.Text;
            fr.Show();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int selected = dataGridView1.SelectedCells[0].RowIndex;
            RchComplaint.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrameHomePage fr = new FrameHomePage();
            fr.Show();

        }
    }
}
