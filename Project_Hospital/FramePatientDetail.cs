using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project_Hospital
{
    public partial class FramePatientDetail : Form
    {
        public FramePatientDetail()
        {
            InitializeComponent();
        }

        public String tc;
        Database database = new Database();

        private void BtnSaveAppointment_Click(object sender, EventArgs e)
        {
            
            MySqlCommand command = new MySqlCommand("UPDATE `hospital`.`appointment` SET appointment_status = '1', patient_tc = @p1, " +
                " appointment_complaint = @p2 WHERE id = @p3", database.Connection());
            command.Parameters.AddWithValue("@p1",LblTC.Text);
            command.Parameters.AddWithValue("@p2",RchComp.Text);
            command.Parameters.AddWithValue("@p3", TxtAppId.Text);
            command.ExecuteNonQuery();
            database.Connection().Close();
            MessageBox.Show("It has been saved your appointment.", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }
       
        private void FramePatientDetail_Load(object sender, EventArgs e)
        {


            LblTC.Text = tc;
            MySqlCommand command = new MySqlCommand("SELECT `patient name`,`patient surname` FROM hospital.patient WHERE `patient tc no`=@p1", database.Connection());
            command.Parameters.AddWithValue("@p1", LblTC.Text);
            MySqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {

                LblNameSurname.Text = dr[0] + " " + dr[1];

            }

            database.Connection().Close();
            
            DataTable dt = new DataTable();
            MySqlDataAdapter mySqlData = new MySqlDataAdapter("SELECT * FROM hospital.appointment WHERE patient_tc=" + tc, database.Connection());
            mySqlData.Fill(dt);
            dataGridView1.DataSource = dt;

            /*
            DataTable dt2 = new DataTable();
            MySqlDataAdapter mySqlData2 = new MySqlDataAdapter("SELECT * FROM hospital.appointment", database.Connection());
            mySqlData2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            */

            MySqlCommand command2 = new MySqlCommand("SELECT `department name` FROM hospital.department",database.Connection());
            MySqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read()) {

                CmbDept.Items.Add(dr2[0]);

            }

            database.Connection().Close();

        }

        private void CmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {

            CmbDoc.Items.Clear();

            MySqlCommand command3 = new MySqlCommand("SELECT `doctor name`,`doctor surname` FROM hospital.doctors WHERE `doctor department`=@p1", database.Connection());
            command3.Parameters.AddWithValue("@p1", CmbDept.Text);
            MySqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {

                CmbDoc.Items.Add(dr3[0] + " " + dr3[1]);

            }

            database.Connection().Close();

        }

        private void CmbDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
                    
            DataTable dt3 = new DataTable();
            MySqlCommand command3 = new MySqlCommand("SELECT * FROM hospital.appointment WHERE appointment_department=@p1" +
                 " AND appointment_doctor=@p2 AND appointment_status='0'", database.Connection()); 
            command3.Parameters.AddWithValue("@p1",CmbDept.Text);
             command3.Parameters.AddWithValue("@p2", CmbDoc.Text); 
            MySqlDataAdapter mysql3 = new MySqlDataAdapter(command3); 
            /*
             MySqlDataAdapter mysql3 = new MySqlDataAdapter("SELECT * FROM hospital.appointment WHERE appointment_department=" + 
             CmbDept.Text + "''" +" AND appointment_doctor= " + CmbDoc.Text + "''"+ "AND appointment_status='1' ", database.Connection()); //(MSSQL) */
             mysql3.Fill(dt3);
             dataGridView2.DataSource = dt3;          
            
        }

        private void LnkEditInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FrameEditInformation fr = new FrameEditInformation();
            fr.tcno = LblTC.Text;
            fr.Show();


        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int selected = dataGridView2.SelectedCells[0].RowIndex;
            TxtAppId.Text = dataGridView2.Rows[selected].Cells[0].Value.ToString();

        }

        private void BtnHomepage_Click(object sender, EventArgs e)
        {

            FrameHomePage fr = new FrameHomePage();
            fr.Show();

        }
    }
}
