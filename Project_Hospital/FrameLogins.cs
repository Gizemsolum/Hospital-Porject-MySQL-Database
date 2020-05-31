using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hospital
{
    public partial class FrameLogins : Form
    {
        public FrameLogins()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FramePatientLogin framepat = new FramePatientLogin();
            framepat.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnDoctorLogin_Click(object sender, EventArgs e)
        {

            FrameDoctorLogin framedoc = new FrameDoctorLogin();
            framedoc.Show();
            this.Hide();

        }

        private void BtnSecretaryLogin_Click(object sender, EventArgs e)
        {

            FrameSecretaryLogin framesec= new FrameSecretaryLogin();
            framesec.Show();
            this.Hide();

        }
    }
}
