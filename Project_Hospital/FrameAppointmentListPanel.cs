using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Project_Hospital
{
    public partial class FrameAppointmentListPanel : Form
    {
        public FrameAppointmentListPanel()
        {
            InitializeComponent();
        }

        Database database = new Database();

        private void FrameAppointmentListPanel_Load(object sender, System.EventArgs e)
        {

            DataTable dt = new DataTable();
            MySqlDataAdapter mysql = new MySqlDataAdapter("SELECT * FROM hospital.appointment", database.Connection());
            mysql.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        public int selection;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            selection = dataGridView1.SelectedCells[0].RowIndex;

        }
    }
}
