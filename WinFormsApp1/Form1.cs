using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using SmartConvert.UserC;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WinFormsApp1.UserC;

namespace WinFormsApp1
{

    public partial class SmartConverter : Form
    {


        private PrivateFontCollection _fontCollection;

        public SmartConverter()
        {
            InitializeComponent();
            LoadCustomFont();
            ApplyFontToControls(this);
            Home uc = new Home();
            addUserControl(uc);
        }

        private void LoadCustomFont()
        {
            _fontCollection = new PrivateFontCollection();
            string fontPath = Path.Combine(Application.StartupPath, "Fonts/SF-Pro", "SF-Pro-Display-Light.otf");
            _fontCollection.AddFontFile(fontPath);

            // Define a fonte padr�o para o formul�rio
            this.Font = new Font(_fontCollection.Families[0], 15);
        }

        private void ApplyFontToControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.Font = new Font(_fontCollection.Families[0], 11);
                // Recursivamente aplique a todos os controles filhos
                if (control.Controls.Count > 0)
                {
                    ApplyFontToControls(control);
                }
            }

        }
        private void addUserControl(UserControl userControl)
        {
            PainelContainer.Controls.Clear();
            PainelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SmartConverter_Click(object sender, EventArgs e)
        {
            // Event handler logic here
        }

        private void SmartConverter_Load(object sender, EventArgs e)
        {
            // Event handler logic here
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

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            Home uc = new Home();
            addUserControl(uc);
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Perfil uc = new Perfil();
            addUserControl(uc);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Config uc = new Config();
            addUserControl(uc);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Home uc = new Home();
            addUserControl(uc);
        }

        private void guna2Button3_Click_2(object sender, EventArgs e)
        {
            Conversor uc = new Conversor();
            addUserControl(uc);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Config uc = new Config();
            addUserControl(uc);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            Perfil uc = new Perfil();
            addUserControl(uc);
        }

        private void PainelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
