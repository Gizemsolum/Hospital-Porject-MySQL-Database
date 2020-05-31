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
    public partial class FrameSecretaryDetail : Form
    {
        public FrameSecretaryDetail()
        {
            InitializeComponent();
        }

        Database database = new Database();
        public String tc;
        private void label4_Click(object sender, EventArgs e)
        {

           
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrameSecretaryDetail_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;
            MySqlCommand command = new MySqlCommand("SELECT `secretary name`,`secretary surname` FROM hospital.secretary WHERE `secretary tc no`=@p1", database.Connection());
            command.Parameters.AddWithValue("@p1", LblTC.Text);
            MySqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {

                LblNameSurname.Text = dr[0] + " " + dr[1];

            }

            database.Connection().Close();

            DataTable dt = new DataTable();
            MySqlDataAdapter mySqlData = new MySqlDataAdapter("SELECT `department name` FROM hospital.department", database.Connection());
            mySqlData.Fill(dt);
            dataGridView1.DataSource = dt;

            DataTable dt2 = new DataTable();
            MySqlDataAdapter mySqlData2 = new MySqlDataAdapter("SELECT doctor_name,doctor_surname,doctor_department AS 'hospital.doctors' FROM hospital.doctors", database.Connection());
            mySqlData2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            MySqlCommand command2 = new MySqlCommand("SELECT 'department name' FROM hospital.department", database.Connection());
            MySqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {

                CmbDept.Items.Add(dr2[0]);

            }

            database.Connection().Close();

            MySqlCommand command3 = new MySqlCommand("SELECT doctor_name,doctor_surname FROM hospital.doctors ", database.Connection());
            MySqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {

                CmbDoctor.Items.Add(dr3[0] + " " + dr3[1]);

            }

            database.Connection().Close();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {                        
            
            MySqlCommand commandsave = new MySqlCommand("INSERT INTO `hospital`.`appointment` (`appointment date`, `appointment clock`, appointment_department, appointment_doctor) VALUES (@p1,@p2,@p3,@p4)", database.Connection());
            commandsave.Parameters.AddWithValue("@p1",MskDate.Text);
            commandsave.Parameters.AddWithValue("@p2", MskClock.Text);
            commandsave.Parameters.AddWithValue("@p3", CmbDept.Text);
            commandsave.Parameters.AddWithValue("@p4", CmbDoctor.Text);
            commandsave.ExecuteNonQuery();                        
            database.Connection();
            MessageBox.Show("The appointment has been created.!");


        }

        private void CmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {

            CmbDoctor.Items.Clear();

            MySqlCommand command2 = new MySqlCommand("SELECT doctor_name,doctor_surname FROM hospital.doctors WHERE doctor_department=@p1", database.Connection());
            command2.Parameters.AddWithValue("@p1",CmbDept.Text);
            MySqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {

                CmbDoctor.Items.Add(dr2[0]+" "+dr2[1]);

            }

            database.Connection().Close();

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {

            MySqlCommand command3 = new MySqlCommand("INSERT INTO `hospital`.`announcement` (`announcement`) VALUES (@p1)",database.Connection());
            command3.Parameters.AddWithValue("@p1",RchAnnouncements.Text);
            command3.ExecuteNonQuery();
            database.Connection().Close();
            MessageBox.Show("It has been created announcement");

        }

        private void BtnDocPanel_Click(object sender, EventArgs e)
        {

            FrameDoctorPanel fr = new FrameDoctorPanel();
            fr.Show();

        }

        private void BtnDeptPanel_Click(object sender, EventArgs e)
        {

            FrameDepartmentPanel fr = new FrameDepartmentPanel();
            fr.Show();

        }

        private void BtnAppointmentPanel_Click(object sender, EventArgs e)
        {

            FrameAppointmentListPanel fr = new FrameAppointmentListPanel();
            fr.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrameAnnouncements fr = new FrameAnnouncements();
            fr.Show();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void BtnHomepage_Click(object sender, EventArgs e)
        {

            FrameHomePage fr = new FrameHomePage();
            fr.Show();

        }
    }
}
