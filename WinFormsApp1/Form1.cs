using Guna.UI2.WinForms;
using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class SmartConverter : Form
    {

        
        public SmartConverter()
        {
            InitializeComponent();
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SmartConverter_Click(object sender, EventArgs e)
        {

        }

        private void SmartConverter_Load(object sender, EventArgs e)
        {


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }


        } 

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }

}
