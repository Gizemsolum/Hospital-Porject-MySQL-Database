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
    public partial class FrameAnnouncements : Form
    {
        public FrameAnnouncements()
        {
            InitializeComponent();
        }

        Database database = new Database();
        private void FrameAnnouncements_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            MySqlDataAdapter mysql = new MySqlDataAdapter("SELECT * FROM hospital.announcement",database.Connection());
            mysql.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
